﻿using System;

namespace QLVT_DATHANG
{
   public class MyConfig
   {
      public static string MachineName = Environment.MachineName;

      public const string DisplayMemberDSPM = "TENCN";
      public const string ValueMemberDSPM = "TENSERVER";
      public const string DatabaseName = "QLVT_DATHANG";
      public const string RemoteLogin = "HTKN";
      public const string RemotePassword = "123456";

      public const string ExecSPThongTinDangNhap = "EXEC sp_login '{0}'";
      public const string ExecSPTimNhanVien = "EXEC sp_timnhanvien {0}";
      public const string ExecSPTimVatTu = "EXEC sp_timvattu '{0}'";
      public const string ExecSPTaoTaiKhoan = "EXEC sp_createlogin '{0}', '{1}', '{2}', '{3}'";
   }
}