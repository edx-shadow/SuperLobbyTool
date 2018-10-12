using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SuperLobbyTool
{
	// Token: 0x02000008 RID: 8
	public class RijndaelManagedEncryption
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00003AFC File Offset: 0x00001CFC
		public static string EncryptRijndael(string text)
		{
			DebugTools.Write("Rijindeal Managed Encryption: Encrypting Text... ");
			if (string.IsNullOrEmpty(text))
			{
				Debug.Print("done.");
				return "";
			}
			RijndaelManaged rijndaelManaged = RijndaelManagedEncryption.NewRijndaelManaged("PICeOLJdNZ3RjieaC3dfd07qPZeIb3DvkP6Zwb5TOmavgpXDQzrBgT5HrUqOFL6l");
			ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			MemoryStream memoryStream = new MemoryStream();
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
			{
				using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
				{
					streamWriter.Write(text);
				}
			}
			Debug.Print("done.");
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003BB4 File Offset: 0x00001DB4
		public static bool IsBase64String(string base64String)
		{
			base64String = base64String.Trim();
			return base64String.Length % 4 == 0 && Regex.IsMatch(base64String, "^[a-zA-Z0-9\\+/]*={0,3}$", RegexOptions.None);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003BD8 File Offset: 0x00001DD8
		public static string DecryptRijndael(string cipherText)
		{
			DebugTools.Write("Rijindeal Managed Encryption: Decrypting Text... ");
			string result;
			try
			{
				if (string.IsNullOrEmpty(cipherText))
				{
					Debug.Print("done.");
					return "";
				}
				if (!RijndaelManagedEncryption.IsBase64String(cipherText))
				{
					throw new Exception("The cipherText input parameter is not base64 encoded.");
				}
				RijndaelManaged rijndaelManaged = RijndaelManagedEncryption.NewRijndaelManaged("PICeOLJdNZ3RjieaC3dfd07qPZeIb3DvkP6Zwb5TOmavgpXDQzrBgT5HrUqOFL6l");
				ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
				using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cipherText)))
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
					{
						using (StreamReader streamReader = new StreamReader(cryptoStream))
						{
							result = streamReader.ReadToEnd();
						}
					}
				}
			}
			catch (Exception ex)
			{
				DebugTools.Print("Failed to decrypt text: " + ex.Message);
				MessageBox.Show("Failed to decrypt text, an error occured:\n\n" + ex.Message, "Decryption", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = "";
			}
			Debug.Print("done.");
			return result;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003D14 File Offset: 0x00001F14
		private static RijndaelManaged NewRijndaelManaged(string salt)
		{
			if (salt == null)
			{
				throw new ArgumentNullException("salt");
			}
			byte[] bytes = Encoding.ASCII.GetBytes(salt);
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("8e0f95e4-bd47-49d2-a275-18062e2db797", bytes);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			return rijndaelManaged;
		}

		// Token: 0x0400002B RID: 43
		internal const string Inputkey = "8e0f95e4-bd47-49d2-a275-18062e2db797";

		// Token: 0x0400002C RID: 44
		internal const string salt = "PICeOLJdNZ3RjieaC3dfd07qPZeIb3DvkP6Zwb5TOmavgpXDQzrBgT5HrUqOFL6l";
	}
}
