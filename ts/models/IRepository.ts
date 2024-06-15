import { Iloan } from "./Iloan";

export interface IRepository<T> {
  ChangeStatus(loan:Iloan): T;
}
