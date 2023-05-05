using System;
using JARVIS.Models;
using Refit;

namespace JARVIS.Services;

public interface IJarvisService
{
    [Post("/v1/completions")]
    Task<JarvisResponse> PromptAsync(JarvisPrompt prompt);
}

