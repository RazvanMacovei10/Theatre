import { Address } from "./address";

export interface RegisterForm{
    id: number,
    username:string,
    address:Address,
    totalSeats:string,
    image:Uint8Array
}