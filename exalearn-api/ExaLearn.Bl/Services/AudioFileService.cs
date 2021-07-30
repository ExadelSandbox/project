﻿using ExaLearn.Bl.Interfaces;
using ExaLearn.Dal.Model;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ExaLearn.Bl.FileFormats;
using Microsoft.Extensions.Configuration;
using System.Linq;
using ExaLearn.Dal.Interfaces;
using System.ComponentModel.DataAnnotations;
using System;
using AutoMapper;
using ExaLearn.Bl.DTO;

namespace ExaLearn.Bl.Services
{
    public class AudioFileService : IAudioFileService
    {
        private readonly IAudioFileRepository _audioFileRepository;
        private readonly IConfiguration _configuration; //it should be in startup.. but for now i do it like this
        private readonly IMapper _mapper;

        public AudioFileService(IAudioFileRepository audioFileRepository, IConfiguration configuration, IMapper mapper)
        {
            _audioFileRepository = audioFileRepository;
            _configuration = configuration;
            _mapper = mapper;
        }

        public async Task<AudioFileDTO> CreateAsync(IFormFile file)
        {
            if (file == null)
                throw new ValidationException("File not found!");

            var fileType = Path.GetExtension(file.FileName);
            var isNessesaryFormat = AudioExtensions.AvailableAudutionExtensions.Contains(fileType.ToLower());

            if (!isNessesaryFormat)
            {
                var availableFormats = string.Join(", ", AudioExtensions.AvailableAudutionExtensions);
                throw new ValidationException("File format does not meet the requirements!: " + availableFormats);
            }

            var filePath = _configuration.GetConnectionString("HostingContext");

            await using (var stream = new FileStream(Path.Combine(filePath, Path.GetRandomFileName()), FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            var fileEntry = new AudioFile()
            {
                Name = file.Name,
                Url = filePath
            };

            var fileDTO = _mapper.Map<AudioFile>(fileEntry);
            fileDTO = await _audioFileRepository.CreateAsync(fileDTO);

            return _mapper.Map<AudioFileDTO>(fileDTO);
        }

        public async Task<AudioFileDTO> GetByIdAsync(int id)
        {
            var file = await _audioFileRepository.GetByIdAsync(id);
            return _mapper.Map<AudioFileDTO>(file);
        }

        public async Task<List<AudioFileDTO>> GetFilesAsync()
        {
            var file = await _audioFileRepository.GetAllAsync();
            return _mapper.Map<List<AudioFileDTO>>(file);
        }
    }
}