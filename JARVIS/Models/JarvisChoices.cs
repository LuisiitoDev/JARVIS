using System;
namespace JARVIS.Models
{
	public record JarvisChoices
	{
		public string Text { get; set; }
		public int Index { get; set; }
		public string LogProbs { get; set; }
		public string FinishReason { get; set; }
	}
}

