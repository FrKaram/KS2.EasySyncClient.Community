﻿/*******************************************************************/
/* EasySync Client                                                 */
/* Author : KaliConseil                                            */
/* http://www.kaliconseil.fr or http://www.ks2.fr                  */
/* contact@ks2.fr                                                  */
/* https://github.com/KaliConseil/EasySyncClient                   */
/*******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KS2.EasySync.Core
{
    public class VirtualElementDeleted
    {
        public VirtualElementType ElementType { get; set; }
        public Guid ElementId { get; set; }
    }
}
