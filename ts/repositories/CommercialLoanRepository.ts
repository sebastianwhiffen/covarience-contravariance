import { IRepository } from '../models/IRepository';
import { Iloan } from '../models/Iloan';
import { CommercialLoan } from '../models/CommercialLoan';

export class CommercialLoanRepository implements IRepository<CommercialLoan> {

    ChangeStatus(loan:Iloan): CommercialLoan {
       loan.status = "approved";
       console.log("CommercialLoanRepository: The loan status has been changed to approved");
       return loan as CommercialLoan;
    }
}