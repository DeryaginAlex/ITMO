    using System;
namespace ITMO.CSharp.Lab10.Exercise1 {
	public class BankTransaction {
		private readonly decimal amount;
		private readonly DateTime when;
		public BankTransaction(decimal tranAmount) {
			amount = tranAmount;
			when = DateTime.Now;
		}
		public decimal Amount() {
			return amount;
		}
		public DateTime When() {
			return when;
		}
	}
}