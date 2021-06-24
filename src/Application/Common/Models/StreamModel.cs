using Domain.Entities;
using Domain.Enums;
using System;

namespace Application.Common.Models
{
    public class StreamModel
    {
        public string Id { get; set; }
        public string CallId { get; set; }
        public string InjectionUrl { get; set; }
        public string Passphrase { get; set; }
        public int Latency { get; set; }
        public StreamState State { get; set; }
        public DateTime StartingAt { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime EndingAt { get; set; }
        public DateTime EndedAt { get; set; }
        public Protocol Protocol { get; set; }
        public dynamic StreamMode { get; set; }
        public StreamErrorDetails Error { get; set; }
    }
}