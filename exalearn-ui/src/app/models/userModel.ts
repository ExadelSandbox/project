export class User {
	constructor(
		private id: number,
		private roleName: string,
		private email: string,
		private lastName: string,
		private firstName: string,
		private isActive: boolean
	) {}

	get role(): string {
		return this.roleName;
	}

	get currentUserId(): number {
		return this.id;
	}
}
