﻿namespace Devkoes.Restup.WebServer.Http.Headers
{
    internal abstract class HttpSingleQuantifiedHeaderBase : HttpHeaderBase
    {
        public QuantifiedHeaderValue QuantifiedHeaderValue { get; set; }

        public HttpSingleQuantifiedHeaderBase(string name, string value, QuantifiedHeaderValue quantifiedHeaderValue)
            : base(name, value)
        {
            QuantifiedHeaderValue = quantifiedHeaderValue;

        }
    }
}
