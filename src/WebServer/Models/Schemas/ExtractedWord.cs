﻿namespace Devkoes.Restup.WebServer.Models.Schemas
{
    internal struct ExtractedWord
    {
        public string Word { get; set; }
        public byte[] RemainingBytes { get; set; }
        public bool WordFound { get; set; }
    }
}
