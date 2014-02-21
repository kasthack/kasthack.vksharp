﻿using System;
using System.IO;
using kasthack.Tools;
using VKSharp;
using VKSharp.Core.Enums;
using VKSharp.Data.Api;
using VKSharp.Data.Parameters;

namespace TestApp {
    class Program {
        static void Main() {
            var vk = new VKApi();
#if !DEBUG
            var str = VKToken.GetOAuthURL( 3174839,VKPermission.Everything^(VKPermission.Notify|VKPermission.Nohttps) );
            str.Dump();
            var redirecturl = ConTools.ReadLine( "Enter redirect url or Ctrl-C" );
#else
            var redirecturl = File.ReadAllText( "debug.token" );
#endif
            try {
                vk.AddToken(VKToken.FromRedirectUrl(redirecturl));
            }
            catch ( FormatException ex ) {
                ConTools.WriteError( ex.Message );
                Console.ReadLine();
                return;
            }
            //var ids = Enumerable.Range( 2000, 3000 ).Select( a=>(uint) a).ToArray();
            var userQuery = vk.UsersGet( UserFields.Bdate | UserFields.Universities, NameCase.Nom,  1, 8878040  );
            //userQuery.Dump();
            //var followersQuery = vk.UsersGetFollowers( 1u );
            //followersQuery.Items.Dump();
            //var friendsQuery = vk.FriendsGet(8878040, UserSortOrder.ById, null, 0, 100, UserFields.Everything);
            //friendsQuery.Dump();
            //var friendsPhone = vk.FriendsGetByPhones(new ulong[] {79312602112});
            //friendsPhone.Dump();
            //var isAppUserQuery = vk.UserIsAppUser( 8878040 );
            //isAppUserQuery.Data.Dump();

            //var au = vk.AudiosGet();
            //var cnt = 100;
            //var outpath = @"B:\audio";
            //foreach (var audio in au.Take( cnt )) {
            //    var name = audio.Artist + " - " + audio.Title;
            //    name.Dump();
            //    AWC.DownloadFile( audio.Url, Path.Combine( outpath, name+".mp3" ) );
            //}

            Console.ReadLine();
        }
    }
}
