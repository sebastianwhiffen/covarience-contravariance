import { Iloan } from "./Iloan";

export class CommercialLoan implements Iloan
{
    constructor(id: string, status: string, companyBorrowerName: string)
    {
        this.id = id;
        this.status = status;
        this.companyBorrowerName = companyBorrowerName;
    }

    id: string;
    status: string = "submited";
    companyBorrowerName: string;
}