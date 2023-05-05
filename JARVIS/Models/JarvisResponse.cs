using System;
namespace JARVIS.Models
{
	public class JarvisResponse
	{
		public string Id { get; set; }
		public string Object { get; set; }
		public int Created { get; set; }
		public string Model { get; set; }
		public JarvisChoices Choises { get; set; }
		public JarvisUsage Usage { get; set; }
	}
}

