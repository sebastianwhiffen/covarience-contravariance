import { Iloan } from "./Iloan";

export class CommercialLoan implements Iloan
{
    constructor(id: string, status: string)
    {
        this.id = id;
        this.status = status;
    }

    id: string;
    status: string = "submited";
}