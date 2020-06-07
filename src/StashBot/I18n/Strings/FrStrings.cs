using System.Collections.Generic;

namespace StashBot.I18n.Strings
{
    public class FrStrings
    {
        public static Dictionary<Localization.Phrase, string> StringDictionary = new Dictionary<Localization.Phrase, string>() {
            { Localization.Phrase.AlreadyBeenQueued, "Cela a déjà été mis en file d'attente" },
            { Localization.Phrase.Author, "Auteur" },
            { Localization.Phrase.CannotDeleteXFromChannel, "Ne peut pas supprimer le #[0] de la chaîne"},
            { Localization.Phrase.CannotFindAuthor, "Impossible de trouver <code>[0]</code>" },
            { Localization.Phrase.CannotFindMessageX, "Impossible de trouver le message #<code>[0]</code>"},
            { Localization.Phrase.CannotRemovePermissionFromSelf, "Vous ne pouvez pas supprimer cette autorisation de vous-même"},
            { Localization.Phrase.CreatedNewAuthor, "Un nouvel utilisateur a lancé le bot, <b>[0]</b> (<code>[1]</code>). Définissez les autorisations avec <code>/user [1]</code>."},
            { Localization.Phrase.Delete, "Supprimer" },
            { Localization.Phrase.DeleteOthers, "Supprimer les autres" },
            { Localization.Phrase.DeletedFromQueue, "Supprimé de la file d'attente"},
            { Localization.Phrase.DeletedXFromChannel, "Supprimé #[0] de la chaîne"},
            { Localization.Phrase.Earlier, "Plus tôt" },
            { Localization.Phrase.Earliest, "Premier" },
            { Localization.Phrase.FlushDanglingUsers, "Purger les utilisateurs inutiles" },
            { Localization.Phrase.FlushQueue, "Purger la file d'attente" },
            { Localization.Phrase.FlushRemovedPosts, "Purger les messages supprimés" },
            { Localization.Phrase.FlushedRemovedPosts, "Messages supprimés purgés" },
            { Localization.Phrase.FlushedXDanglingUsers, "Purgé [0] utilisateurs inutiles" },
            { Localization.Phrase.InvalidArgsSeeHelp, "Arguments non valides: voir <code>/help [0]</code> pour plus de détails" },
            { Localization.Phrase.Later, "Plus tard" },
            { Localization.Phrase.Latest, "Dernier" },
            { Localization.Phrase.LinkContainsNoMedia, "Ce lien ne contient aucun média ou n'existe pas" },
            { Localization.Phrase.LoadingQueue, "Chargement de la file d'attente..." },
            { Localization.Phrase.ManageUsers, "Gérer les utilisateurs" },
            { Localization.Phrase.MessageID, "ID du message" },
            { Localization.Phrase.Name, "Nom" },
            { Localization.Phrase.NoDanglingUsers, "Aucun utilisateur inutile à purger" },
            { Localization.Phrase.NotSet, "Pas encore défini"},
            { Localization.Phrase.NothingIsPosted, "Rien n'a été posté" },
            { Localization.Phrase.NothingIsQueued, "Rien n'est mis en file d'attente" },
            { Localization.Phrase.NoPermissionFlushDanglingUsers, "Vous n'êtes pas autorisé à purger les utilisateurs inutiles" },
            { Localization.Phrase.NoPermissionFlushRemovedPosts, "Vous n'êtes pas autorisé à purger les messages supprimés" },
            { Localization.Phrase.NoPermissionManageUsers, "Vous n'êtes pas autorisé à gérer les utilisateurs"},
            { Localization.Phrase.NoPermissionPostQueue, "Vous n'êtes pas autorisé à mettre en file d'attente de nouveaux posts" },
            { Localization.Phrase.NoPermissionRemovePost, "Vous n'êtes pas autorisé à supprimer ce post" },
            { Localization.Phrase.NoPermissionTools, "Vous n'êtes pas autorisé à utiliser des outils" },
            { Localization.Phrase.NoPermissionViewQueue, "Vous n'êtes pas autorisé à afficher la file d'attente" },
            { Localization.Phrase.PostSuccessfullyQueued, "Post mis en file d'attente avec succès" },
            { Localization.Phrase.Posted, "Publié" },
            { Localization.Phrase.Posts, "Messages" },
            { Localization.Phrase.ProfileUpdated, "Profil mis à jour"},
            { Localization.Phrase.Queue, "Queue" },
            { Localization.Phrase.Queued, "Attente"},
            { Localization.Phrase.RefreshProfile, "Rafraîchir le profil" },
            { Localization.Phrase.RefreshedProfileHelloX, "Profil actualisé. Bonjour [0]!" },
            { Localization.Phrase.ServiceNotSupported, "Ce service n'est pas pris en charge" },
            { Localization.Phrase.Sooner, "Plus tôt" },
            { Localization.Phrase.Soonest, "Premier" },
            { Localization.Phrase.Tools, "Outils" },
            { Localization.Phrase.User, "Utilisateur" },
            { Localization.Phrase.Username, "Identifiant" },
            { Localization.Phrase.WelcomeFirstAuthor, $"<b>Bienvenue sur StashBot, [0] !</b><br />Définissez vos autorisations avec <code>/user [0]</code> (ou simplement <code>/user</code>)." }
        };
    }
}