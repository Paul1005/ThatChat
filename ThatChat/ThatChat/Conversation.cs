﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThatChat
{
    public class Conversation
    {
        public string Name { get; private set; }

        public List<Message> Messages { get; private set; }

        public Conversation(string name)
        {
            this.Name = name;
            Messages = new List<Message>();
        }
    }
}