namespace SiaCRM
{
	public class Customer
	{
		public int id { get; set; }
		public string Name { get; set; }
	}

	public class Service
	{
		public int Folio { get; set; }
		public int Customer { get; set; }
		public string Name { get; set; }
		public string AdmissionDate { get; set; }
		public string DeliveryDate { get; set; }
		public string Status { get; set; }
		public string Diagnostic { get; set; }
	}
}
