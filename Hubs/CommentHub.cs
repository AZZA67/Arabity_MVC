using Arabitey.Models;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace Arabitey.Hubs
{
    public class CommentHub:Hub
    {
        EntityContext EntityContext;
        // new EntityContext();
        public CommentHub(EntityContext EntityContext)
        {
            this.EntityContext = EntityContext;
        }
     
        public  void Make_comment(string username, string comment, int postId)
        {
           
            EntityContext.comment.Add(new Comment() { postId = postId, UserName = username, Text = comment });
            EntityContext.SaveChanges();
            // Context.User.Identity.Name
            Clients.All.SendAsync("Display", username, comment, postId);
        }
    }
}
