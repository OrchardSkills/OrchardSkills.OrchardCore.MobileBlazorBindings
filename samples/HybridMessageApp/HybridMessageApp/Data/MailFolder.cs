﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace HybridMessageApp.Data
{
    public class MailFolder
    {
        public string Id { get; set; }
        public Message[] Mails { get; set; }
    }
}
