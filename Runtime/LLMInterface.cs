using System;
using System.Collections.Generic;
using UnityEngine;

namespace LLMUnity
{
    [Serializable]
    public struct ChatRequest
    {
        public string prompt;
        public float temperature;
        public int top_k;
        public float top_p;
        public int n_predict;
        public int n_keep;
        public bool stream;
        public int seed;
        public bool cache_prompt;
        public List<ChatMessage> messages;
        public List<string> stop;
    }

    [Serializable]
    public struct ChatResult
    {
        public string content;
        public bool multimodal;
        public int slot_id;
        public bool stop;
        public string generation_settings;
        public string model;
        public string prompt;
        public bool stopped_eos;
        public bool stopped_limit;
        public bool stopped_word;
        public string stopping_word;
        public string timings;
        public int tokens_cached;
        public int tokens_evaluated;
        public bool truncated;
        public bool cache_prompt;
        public bool system_prompt;
    }

    [Serializable]
    public struct MultiChatResult
    {
        public List<ChatResult> data;
    }

    [Serializable]
    public struct ChatMessage
    {
        public string role;
        public string content;
    }

    [Serializable]
    public struct ChatOpenAIRequest
    {
        public List<ChatMessage> messages;
    }

    [Serializable]
    public struct ChatOpenAIResultChoice
    {
        public string finish_reason;
        public int index;
        public ChatMessage message;
        public ChatMessage delta;
    }

    [Serializable]
    public struct ChatOpenAIResultNumTokens
    {
        public int completion_tokens;
        public int prompt_tokens;
        public int total_tokens;
    }

    [Serializable]
    public struct ChatOpenAIResult
    {
        public string id;
        public ChatOpenAIResultNumTokens usage;
        // [JsonProperty("object")]
        // public string MyObject { get; set; }
        public string model;
        public Time created;
        public List<ChatOpenAIResultChoice> choices;
    }

    [Serializable]
    public struct TokenizeRequest
    {
        public string content;
    }

    [Serializable]
    public struct TokenizeResult
    {
        public List<int> tokens;
    }

    [Serializable]
    public struct ServerStatus
    {
        public DateTime timestamp;
        public string level;
        public string function;
        public int line;
        public string message;
        public string hostname;
        public int port;
    }
}
