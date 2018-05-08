﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Reactor.Core.Domain.Comments;
using Reactor.Core.Domain.Friends;
using Reactor.Core.Domain.Posts;

namespace Reactor.Core.Domain.Users
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ProfilePictureUrl { get; set; }    

        public ICollection<Friend> SentFriendRequests { get; set; }

        public ICollection<Friend> ReceievedFriendRequests { get; set; }

        public ICollection<Post> Posts { get; set; }

        [NotMapped] public string FullName => $"{FirstName} {LastName}";
        
        public ICollection<Comment> Comments { get; set; }


        public User()
        {
            SentFriendRequests = new List<Friend>();

            ReceievedFriendRequests = new List<Friend>();
            
            Posts = new List<Post>();
            
            Comments = new List<Comment>();
        }
        
        public virtual IEnumerable<Friend> ApprovedFriends()
        {
            var friends = SentFriendRequests.Where(x => x.Approved).ToList();

            friends.AddRange(ReceievedFriendRequests.Where(x => x.Approved));

            return friends;
        }

        public virtual IEnumerable<Friend> NotApprovedFriends()
        {
            var friends = SentFriendRequests.Where(x => x.NotApproved).ToList();

            friends.AddRange(ReceievedFriendRequests.Where(x => x.NotApproved));

            return friends;
        }

        public string GetPicture()
        {
            return ProfilePictureUrl ?? "/assets/images/no-profile.svg";
        }

    }
}