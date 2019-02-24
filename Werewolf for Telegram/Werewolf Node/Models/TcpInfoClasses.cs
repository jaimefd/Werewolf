﻿using System;
using System.Collections.Generic;
using Telegram.Bot.Types;

namespace Werewolf_Node.Models
{
    public class NodeInfo
    {
        public string JType { get; set; } = "NodeInfo";
        public Guid ClientId { get; set; }
        public int CurrentGames { get; set; }
        public int TotalGames { get; set; }
        public int CurrentPlayers { get; set; }
        public int TotalPlayers { get; set; }
        public int ThreadCount { get; set; }
        public int DuplicateGamesRemoved { get; set; }
        public TimeSpan Uptime { get; set; }
        public HashSet<GameInfo> Games { get; set; } = new HashSet<GameInfo>();
        public string Version { get; set; }
        public bool ShuttingDown { get; set; }
        public int MessagesSent { get; set; }

    }

    public class ClientRegistrationInfo
    {
        public string JType { get; set; } = "ClientRegistrationInfo";
        public Guid ClientId { get; set; }
        public string Secret => Environment.MachineName.GetHashCode().ToString();
    }

    public class PlayerJoinInfo
    {
        public string JType { get; set; } = "PlayerJoinInfo";
        public User User { get; set; }
        public long GroupId { get; set; }
    }

    public class GameStartInfo
    {
        public string JType { get; set; } = "GameStartInfo";
        public int gameMode { get; set; }
        public List<IRole> CList { get; set; } = new List<IRole>();
        public User User { get; set; }
        public Chat Chat { get; set; }
        public bool nHela { get; set; }
        public bool nJiro { get; set; }
        public bool nLara { get; set; }
        public bool nAlex { get; set; }
    }

    public class GameEndInfo
    {
        public string JType { get; set; } = "GameEndInfo";
        public long GroupId { get; set; }
        public int PlayerCount { get; set; }
        public Guid ClientId { get; set; }
    }

    public class ForceStartInfo
    {
        public string JType { get; set; } = "ForceStartInfo";
        public long GroupId { get; set; }
    }

    public class ReplyInfo
    {
        public string JType { get; set; } = "ReplyInfo";
        public Update Update { get; set; }
    }

    public class PlayerListRequestInfo
    {
        public string JType { get; set; } = "PlayerListRequestInfo";
        public long GroupId { get; set; }
    }

    public class RoleListRequestInfo
    {
        public string JType { get; set; } = "RoleListRequestInfo";
        public long GroupId { get; set; }
    }

    public class PlayerFleeInfo
    {
        public string JType { get; set; } = "PlayerFleeInfo";
        public User User { get; set; }
        public long GroupId { get; set; }
    }

    public class UpdateNodeInfo
    {
        public string JType { get; set; } = "UpdateNodeInfo";
        public bool Kill { get; set; } = false;
    }

    public class LoadLangInfo
    {
        public string JType { get; set; } = "LoadLangInfo";
        public string FileName { get; set; }
        public long GroupId { get; set; }
    }

    public class PlayerSmiteInfo
    {
        public string JType { get; set; } = "PlayerSmiteInfo";
        public int UserId { get; set; }
        public long GroupId { get; set; }
    }
    public class CallbackInfo
    {
        public string JType { get; set; } = "CallbackInfo";
        public CallbackQuery Query { get; set; }
    }

    public class SkipVoteInfo
    {
        public string JType { get; set; } = "SkipVoteInfo";
        public long GroupId { get; set; }
    }
    public class GameKillInfo
    {
        public string JType { get; set; } = "GameKillInfo";
        public long GroupId { get; set; }
    }

    public class ExtendTimeInfo
    {
        public string JType { get; set; } = "ExtendTimeInfo";
        public long GroupId { get; set; }
        public long User { get; set; }
        public bool Admin { get; set; }
        public int Seconds { get; set; }
    }
}
