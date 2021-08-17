export const API_PATH = {
	TEST: '/api/questions/generateTest',
	AUTHENTICATE: '/api/authenticate',
	ALL_HISTORY: '/api/users/allTestHistory',
	OWN_HISTORY: '/api/users/{id}/myTestHistory',
	NEW_GRAMMAR: '/api/questions/createGrammar',
	NEW_AUDITION: '/api/questions/createAudition',
	NEW_TOPIC: '/api/questions/createTopic',
	USERS: '/api/users/getUsers',
	USER: '/api/users/user',
	USER_HISTORY: '/api/users/{id}/userHistory',
	MY_ASSIGNED_TESTS: '/api/users/{id}/myAssignedTests',
	POST_USER_ASSIGN_TEST: '/api/users/assignTests',
	USER_ANSWERS: '/api/userAnswers/create',
	HR_USER_HISTORY: '/api/users/{id}/hrUserHistory',
	ALL_ASSIGNED_TEST: '/api/users/allAssignedTests',
	POST_TEST: '/api/userAnswers/create'
};
