import { IRepository } from "./models/IRepository";
import { Iloan } from "./models/Iloan";
import { CommercialLoan } from "./models/CommercialLoan";
import { CommercialLoanRepository } from "./repositories/CommercialLoanRepository";
import { ConsumerLoan } from "./models/ConsumerLoan";
import { ConsumerLoanRepository } from "./repositories/ConsumerLoanRepository";

const repositories: IRepository<Iloan>[] = 
[
    new CommercialLoanRepository(),
    new ConsumerLoanRepository()
];

repositories.forEach(repository => repository.ChangeStatus(new ConsumerLoan("1", "submited")));