import { EnglishLevels } from '../enums/enums';

export class User {
	constructor(
		private id: number,
		private roleName: string,
		private email: string,
		private lastName: string,
		private firstName: string,
		private isActive: boolean,
		private englishLevel: EnglishLevels | null
	) {}

	get role(): string {
		return this.roleName;
	}

	get fullName(): string {
		return this.firstName + ' ' + this.lastName;
	}

	get level(): EnglishLevels | null {
		return this.englishLevel;
	}

	get currentUserId(): number {
		return this.id;
	}
}
