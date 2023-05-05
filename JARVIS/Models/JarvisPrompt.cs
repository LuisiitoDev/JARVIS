using System;
namespace JARVIS.Models
{
	public class JarvisPrompt
	{
		public string Model { get; init; }
		public string Prompt { get; set; }
		public float Temperature { get; init; }
		public int MaxTokens { get; init; }
		public int TopP { get; init; }
		public float FrecuencyPenalty { get; init; }
		public float PresencePenalty { get; init; }
		public string[] Stop { get; set; }

		public JarvisPrompt()
		{
			Model = "text-davinci-003";
			Temperature = 0.5F;
			MaxTokens = 60;
			TopP = 1;
			FrecuencyPenalty = 0.5F;
			PresencePenalty = 0F;
		}
	}
}

