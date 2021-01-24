using System.Collections.Generic;

namespace GearstashBot.I18n.Strings
{
    public class EnStrings
    {
        public static Dictionary<Localization.Phrase, string> StringDictionary = new Dictionary<Localization.Phrase, string>() {
            { Localization.Phrase.AlreadyBeenQueued, "This has already been queued" },
            { Localization.Phrase.Author, "Poster" },
            { Localization.Phrase.Back, "Back" },
            { Localization.Phrase.CannotDeleteXFromChannel, "Cannot delete #[0] from channel"},
            { Localization.Phrase.CannotFetchFile, "Telegram cannot fetch this file (<code>[1]</code>):<br />[0]"},
            { Localization.Phrase.CannotFindAuthor, "Cannot find <code>[0]</code>"},
            { Localization.Phrase.CannotFindMessageX, "Cannot find message #<code>[0]</code>"},
            { Localization.Phrase.CannotDeleteTemporarilyDueToLongRunningRequest, "Cannot delete this item due to a long-running request. Try again in a few seconds."},
            { Localization.Phrase.CannotPostTemporarilyDueToLongRunningRequest, "Cannot post to the queue due to a long-running request. Try again in a few seconds."},
            { Localization.Phrase.CannotRemovePermissionFromSelf, "You cannot remove this permission from yourself"},
            { Localization.Phrase.CreatedNewAuthor, "New user has started the bot, <b>[0]</b> (<code>[1]</code>). Set permissions with <code>/user [1]</code>." },
            { Localization.Phrase.Delete, "Delete" },
            { Localization.Phrase.Deleted, "Deleted" },
            { Localization.Phrase.DeleteOthers, "Delete Others" },
            { Localization.Phrase.DeletedXFromChannel, "Deleted #[0] from channel"},
            { Localization.Phrase.Earlier, "Earlier" },
            { Localization.Phrase.Earliest, "Earliest" },
            { Localization.Phrase.FlushDanglingUsers, "Purge Dangling Users" },
            { Localization.Phrase.FlushedXDanglingUsers, "Purged [0] dangling users" },
            { Localization.Phrase.InvalidArgs, "Invalid arguments" },
            { Localization.Phrase.Language, "Language" },
            { Localization.Phrase.LastAccessed, "Last Accessed" },
            { Localization.Phrase.Later, "Later" },
            { Localization.Phrase.Latest, "Latest" },
            { Localization.Phrase.LinkContainsNoMedia, "This link contains no media or does not exist" },
            { Localization.Phrase.LoadingQueue, "Loading Queue..." },
            { Localization.Phrase.ManageUsers, "Manage Users" },
            { Localization.Phrase.MessageID, "Message ID" },
            { Localization.Phrase.Name, "Name" },
            { Localization.Phrase.NoDanglingUsers, "No dangling users to purge" },
            { Localization.Phrase.NotSet, "Not set"},
            { Localization.Phrase.NothingIsDeleted, "Nothing has been deleted" },
            { Localization.Phrase.NothingIsPosted, "Nothing has been posted" },
            { Localization.Phrase.NothingIsQueued, "Nothing is queued" },
            { Localization.Phrase.NoPermissionFlushDanglingUsers, "You do not have permission to purge dangling users" },
            { Localization.Phrase.NoPermissionManageUsers, "You do not have permission to manage users"},
            { Localization.Phrase.NoPermissionPostQueue, "You do not have permission to queue new posts" },
            { Localization.Phrase.NoPermissionRandomizeQueue, "You do not have permission to randomize the queue"},
            { Localization.Phrase.NoPermissionRemovePost, "You do not have permission to remove this post" },
            { Localization.Phrase.NoPermissionTools, "You do not have permission to use tools" },
            { Localization.Phrase.NoPermissionViewQueue, "You do not have permission to view the queue"},
            { Localization.Phrase.PostSuccessfullyQueued, "Post successfully queued" },
            { Localization.Phrase.Posted, "Posted" },
            { Localization.Phrase.Posts, "Posts" },
            { Localization.Phrase.ProfileUpdated, "Profile Updated"},
            { Localization.Phrase.Queue, "Queue" },
            { Localization.Phrase.Queued, "Queued"},
            { Localization.Phrase.RandomizeQueue, "Randomize Queue"},
            { Localization.Phrase.RandomizedQueue, "Randomized queue"},
            { Localization.Phrase.RefreshProfile, "Refresh Profile" },
            { Localization.Phrase.RefreshedProfileHelloX, "Refreshed profile. Hello [0]!" },
            { Localization.Phrase.Retry, "Retry" },
            { Localization.Phrase.ServiceNotSupported, "This service is not supported"},
            { Localization.Phrase.Sooner, "Sooner" },
            { Localization.Phrase.Soonest, "Soonest" },
            { Localization.Phrase.Tools, "Tools" },
            { Localization.Phrase.User, "User" },
            { Localization.Phrase.Username, "Username" },
            { Localization.Phrase.Viewing, "Viewing" },
            { Localization.Phrase.WelcomeFirstAuthor, $"<b>Welcome to GearstashBot, [0]!</b><br />Set your permissions with <code>/user [1]</code> (or just <code>/user</code>)." }
        };
    }
}