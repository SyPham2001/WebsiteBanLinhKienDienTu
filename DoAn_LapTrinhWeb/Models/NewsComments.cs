﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using DoAn_LapTrinhWeb.Models;

namespace DoAn_LapTrinhWeb.Models
{
    public class NewsComments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int comment_id { get; set; }
        //account id
        public int account_id { get; set; }
        //news id
        public int news_id { get; set; }
        //comment content
        [StringLength(200, ErrorMessage = "Nội dung bình luận không được quá 200 ký tự")]
        public string comment_content { get; set; }
        //create at
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime create_at { get; set; }
        //update at
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime update_at { get; set; }
        ///status
        [StringLength(1)]
        public string status { get; set; }
        public virtual News News { get; set; }
        public virtual Account Accounts { get; set; }
    }
}