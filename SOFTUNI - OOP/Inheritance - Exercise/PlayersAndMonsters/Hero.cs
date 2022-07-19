﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Hero
    {
        private string username;
        private int level;

        public int Level { get; set; }
        public string Username { get; set; }

        public Hero(string username, int level)
        {
            this.Username = username;
            this.Level = level;
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
