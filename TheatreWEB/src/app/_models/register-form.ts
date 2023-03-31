import { Address } from "./address";

export interface RegisterForm{
    username:string,
    address:Address,
    totalSeats:string,
    password:string,
    email:string,
    image:string
}