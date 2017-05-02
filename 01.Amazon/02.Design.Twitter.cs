using System.Collections.Generic;
using System.Linq;

namespace _01.Amazon
{

    public class Following
    {
        public int FolloweeId;
        public int FollowerId;
        public Following(int followeeId, int followerId)
        {
            FolloweeId = followeeId;
            FollowerId = followerId;
        }
    }

    public class Tweet
    {
        public int TweetId;
        public int UserId;
        public Tweet(int tweetId, int userId)
        {
            TweetId = tweetId;
            UserId = userId;
        }

    }

    public class Twitter
    {

        public List<Following> Followings;
        public List<Tweet> Tweets;

        public Twitter()
        {
            Followings = new List<Following>();
            Tweets = new List<Tweet>();
        }

        /** Compose a new tweet. */
        public void PostTweet(int userId, int tweetId)
        {
            Tweets.Add(new Tweet(tweetId, userId));
        }

        /** Retrieve the 10 most recent tweet ids in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent. */
        public IList<int> GetNewsFeed(int userId)
        {
            var outputs = new List<int>();
            var users = new List<int>();
            if (Followings != null && Followings.Count > 0)
                users = Followings.Where(f => f.FollowerId == userId).Select(f => f.FolloweeId).ToList();
            if (Tweets != null && Tweets.Count > 0)
            {
                for (int i = Tweets.Count - 1; i >= 0; i--)
                {
                    if (Tweets[i].UserId == userId || users.Contains(Tweets[i].UserId))
                        outputs.Add(Tweets[i].TweetId);
                    if (outputs.Count == 10) return outputs;
                }
            }
            return outputs;
        }

        /** Follower follows a followee. If the operation is invalid, it should be a no-op. */
        public void Follow(int followerId, int followeeId)
        {
            var following = new Following(followeeId, followerId);
            if (Followings != null && Followings.Count > 0)
            {
                if (!Followings.Contains(following)) Followings.Add(following);
                return;
            }
            Followings.Add(following);
        }

        /** Follower unfollows a followee. If the operation is invalid, it should be a no-op. */
        public void Unfollow(int followerId, int followeeId)
        {
            if (Followings != null && Followings.Count > 0)
                Followings.RemoveAll(f => f.FolloweeId == followeeId && f.FollowerId == followerId);
        }

    }

    public class _02DesignTwitter
    {

        public static void Answer()
        {
            var twitter1 = new Twitter();
            twitter1.PostTweet(1, 5);
            var outputs1 = twitter1.GetNewsFeed(1);
            twitter1.Follow(1, 2);
            twitter1.Unfollow(1, 2);

            var twitter2 = new Twitter();
            twitter1.PostTweet(1, 5);
            twitter1.PostTweet(1, 3);
            twitter1.PostTweet(1, 101);
            twitter1.PostTweet(1, 13);
            twitter1.PostTweet(1, 10);
            twitter1.PostTweet(1, 2);
            twitter1.PostTweet(1, 94);
            twitter1.PostTweet(1, 505);
            twitter1.PostTweet(1, 333);
            twitter1.PostTweet(1, 22);
            twitter1.PostTweet(1, 11);
            var outputs2 = twitter1.GetNewsFeed(1);
        }

    }

}
