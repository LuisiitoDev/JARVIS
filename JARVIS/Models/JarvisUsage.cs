using System;
namespace JARVIS.Models
{
	public record JarvisUsage
	{
		public int PromptTokens { get; set; }
		public int CompletionTokens { get; set; }
		public int TotalTokens { get; set; }
	}
}

