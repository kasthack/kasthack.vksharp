﻿using System;
using kasthack.vksharp.DataTypes.EntityFragments;

namespace kasthack.vksharp.DataTypes.Entities {
    public class Comment {
        public long Id{ get; set; }
        public int FromId{ get; set; }
        public DateTimeOffset Date { get; set; }
        public string Text { get; set; }
        public int ReplyToUser{ get; set; }
        public long ReplyToComment { get; set; }
        public Attachment[] Attachments { get; set; }
        public CommentLikes Likes { get; set; }
    }
}