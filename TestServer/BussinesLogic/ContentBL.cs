using Microsoft.Extensions.Logging;

namespace TestServer.BussinesLogic
{
    public class ContentBL
    {
        //private readonly gimsqlContext gimsqlContext;

        //public ContentBL(gimsqlContext gimsqlContext)
        //{
        //    this.gimsqlContext = gimsqlContext;

        //}
        //public async Task<List<PostBL>> GetContentArticles()
        //{
        //    List<PostBL> result = new List<PostBL>();
        //    logger.LogDebug("ContentArticlesBL Start");
        //    try
        //    {
        //        var gimPosts = await gimsqlContext.GimPosts.ToListAsync();
        //        if (gimPosts != null)
        //        {
        //            var attachments = gimPosts.Where(gp => gp.PostType.Equals("attachment") && gp.PostParent != 0)
        //                  .GroupBy(p => p.PostParent).ToList();

        //            var gimPostsPublished = gimPosts.Where(p => p.PostStatus.Equals("publish") &&
        //                                                   p.PostParent == 0 &&
        //                                                   p.PostType.Equals("post")).ToList();
        //            ///*Remove*/  gimPostsPublished.RemoveRange(200, 2000);

        //            result = await MappingList(gimPostsPublished, attachments);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.LogError($"GetContentArticles Error - {ex}");
        //        return result;
        //    }
        //    logger.LogDebug("GetContentArticles end");
        //    return result;
        //}

        //private async Task<List<PostBL>> MappingList(List<GimPost> gimPostsPublished, List<IGrouping<long, GimPost>> attachments)
        //{
        //    List<PostBL> posts = new List<PostBL>();
        //    gimPostsPublished.ForEach(async gp =>
        //    {
        //        string content = GetFixedContent(gp.PostContent);
        //        var post = new PostBL()
        //        {
        //            Id = gp.Id,
        //            AuthorName = await GetNameAuthor(gp.PostAuthor),
        //            DatePublished = Convert.ToDateTime(gp.PostDate),
        //            Title = gp.PostTitle,
        //            Image = GetImageUrlFromContent(ref content),
        //            Content = content,
        //            Subject = await GetNameSubject(gp.Id),
        //            Gallery = attachments.Where(a => a.Key == gp.Id).ToList().SelectMany(g => g.Select(i => i.Guid)).ToList()
        //        };
        //        posts.Add(post);
        //    });
        //    return posts;
        //}
    }
}
