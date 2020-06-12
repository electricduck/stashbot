using System.Collections.Generic;

namespace StashBot.I18n.Strings
{
    public class DeStrings
    {
        public static Dictionary<Localization.Phrase, string> StringDictionary = new Dictionary<Localization.Phrase, string>() {
            { Localization.Phrase.AlreadyBeenQueued, "Dies wurde bereits in die Warteschlange gestellt" },
            { Localization.Phrase.Author, "Autor" },
            { Localization.Phrase.CannotDeleteXFromChannel, "#[0] kann nicht aus dem Kanal gelöscht werden"},
            { Localization.Phrase.CannotFetchFile, "Telegram kann diese Datei nicht herunterladen (<code>[1]</code>):<br />[0]"},
            { Localization.Phrase.CannotFindAuthor, "Kann <code>[0]</code> nicht finden" },
            { Localization.Phrase.CannotFindMessageX, "Nachricht #<code>[0]</code> kann nicht gefunden werden"},
            { Localization.Phrase.CannotRemovePermissionFromSelf, "Sie können diese Berechtigung nicht von sich selbst entfernen"},
            { Localization.Phrase.CreatedNewAuthor, "Neuer Benutzer hat den Bot gestartet, [0] (<code>[1]</code>). Berechtigungen mit <code>/user [1]</code> setzen."},
            { Localization.Phrase.Delete, "Löschen" },
            { Localization.Phrase.DeleteOthers, "Andere löschen" },
            { Localization.Phrase.DeletedFromQueue, "Aus der Warteschlange gelöscht"},
            { Localization.Phrase.DeletedXFromChannel, "#[0] aus dem Kanal gelöscht"},
            { Localization.Phrase.Earlier, "Früher" },
            { Localization.Phrase.Earliest, "Früheste" },
            { Localization.Phrase.FlushDanglingUsers, "Nutzlose Benutzer löschen" },
            { Localization.Phrase.FlushQueue, "Warteschlange löschen" },
            { Localization.Phrase.FlushRemovedPosts, "Entfernte Beiträge löschen" },
            { Localization.Phrase.FlushedRemovedPosts, "Entfernte Pfosten löschen" },
            { Localization.Phrase.FlushedXDanglingUsers, "[0] nutzlose Benutzer gelöscht" },
            { Localization.Phrase.InvalidArgsSeeHelp, "Ungültige Argumente: Einzelheiten finden Sie in <code>/help [0]</code>" },
            { Localization.Phrase.Later, "Später" },
            { Localization.Phrase.Latest, "Aktuellste" },
            { Localization.Phrase.LinkContainsNoMedia, "Dieser Link enthält keine Medien oder existiert nicht" },
            { Localization.Phrase.LoadingQueue, "Lade-Warteschlange..." },
            { Localization.Phrase.ManageUsers, "Benutzer verwalten" },
            { Localization.Phrase.MessageID, "Nachrichten ID" },
            { Localization.Phrase.Name, "Name" },
            { Localization.Phrase.NoDanglingUsers, "Keine nutzlosen Benutzer zum Löschen" },
            { Localization.Phrase.NotSet, "Nicht eingestellt" },
            { Localization.Phrase.NothingIsPosted, "Es wurde nichts gepostet" },
            { Localization.Phrase.NothingIsQueued, "Nichts steht in der Warteschlange" },
            { Localization.Phrase.NoPermissionFlushDanglingUsers, "Sie haben keine Berechtigung, nutzlose Benutzer zu löschen" },
            { Localization.Phrase.NoPermissionFlushRemovedPosts, "Sie haben keine Berechtigung zum Entfernen entfernter Beiträge" },
            { Localization.Phrase.NoPermissionManageUsers, "Sie haben keine Berechtigung zum Verwalten von Benutzern" },
            { Localization.Phrase.NoPermissionPostQueue, "Sie haben keine Berechtigung, neue Beiträge in die Warteschlange zu stellen" },
            { Localization.Phrase.NoPermissionRemovePost, "Sie haben keine Berechtigung, diesen Beitrag zu entfernen" },
            { Localization.Phrase.NoPermissionTools, "Sie haben keine Berechtigung zur Verwendung von Tools" },
            { Localization.Phrase.NoPermissionViewQueue, "Sie haben keine Berechtigung zum Anzeigen der Warteschlange" },
            { Localization.Phrase.PostSuccessfullyQueued, "Beitrag erfolgreich in die Warteschlange gestellt" },
            { Localization.Phrase.Posted, "Geschrieben" },
            { Localization.Phrase.Posts, "Beiträge" },
            { Localization.Phrase.ProfileUpdated, "Profil aktualisiert"},
            { Localization.Phrase.Queue, "Warteschlange" },
            { Localization.Phrase.Queued, "Warteschlange"},
            { Localization.Phrase.RefreshProfile, "Profil auffrischen" },
            { Localization.Phrase.RefreshedProfileHelloX, "Aktualisiertes Profil. Hallo [0]!" },
            { Localization.Phrase.ServiceNotSupported, "Dieser Dienst wird nicht unterstützt" },
            { Localization.Phrase.Sooner, "Bald" },
            { Localization.Phrase.Soonest, "Demnächst" },
            { Localization.Phrase.Tools, "Werkzeuge" },
            { Localization.Phrase.User, "Benutzer" },
            { Localization.Phrase.Username, "Nutzername" },
            { Localization.Phrase.WelcomeFirstAuthor, $"<b>Willkommen bei StashBot, [0]!</b><br />Setzen Sie Ihre Berechtigungen mit <code>/user [1]</code> (oder nur <code>/user</code>)." }
        };
    }
}