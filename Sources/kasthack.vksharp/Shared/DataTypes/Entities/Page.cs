﻿using System;
using kasthack.vksharp.DataTypes.Enums;

namespace kasthack.vksharp.DataTypes.Entities {

    public class Page {

        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Title { get; set; }
        public bool? CurrentUserCanEdit { get; set; }
        public bool? CurrentUserCanEditAccess { get; set; }
        public int WhoCanView { get; set; } //todo: enum
        public int WhoCanEdit { get; set; } //todo: enum
        public DateTimeOffset? Edited { get; set; }
        public DateTimeOffset Created { get; set; }
        public int Views { get; set; }
        public int? EditorId { get; set; }
        public int CreatorId { get; set; }
        public string ViewUrl { get; set; }

        public static implicit operator ObjectContentId(Page page) => new ObjectContentId( ContentType.Page, page.Id, -page.GroupId );
        public static implicit operator ContentId(Page page) => (ObjectContentId)page;
    }

}