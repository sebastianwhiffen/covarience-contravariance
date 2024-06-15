import { IRepository } from '../models/IRepository';
import { Iloan } from '../models/Iloan';
import { ConsumerLoan } from '../models/ConsumerLoan';
import { CommercialLoan } from '../models/CommercialLoan';

export class ConsumerLoanRepository implements IRepository<CommercialLoan> {

    ChangeStatus(loan:Iloan): ConsumerLoan {
       loan.status = "Declined"
       console.log("ConsumerLoanRepository: The loan status has been changed to Declined");
       return loan as ConsumerLoan;
    }
}