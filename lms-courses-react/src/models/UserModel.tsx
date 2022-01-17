import { RoleList } from "./RoleModel";

export interface UserList {
    Id: number,
    Name: string,
    Avatar: string,
    Email: string,
    Department: string,
    Manager: string,
    Role: RoleList
}