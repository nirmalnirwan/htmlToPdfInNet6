using iText.Html2pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Pdf;
using iText.Kernel.Font;
using iText.Kernel.Colors;
using iText.Kernel.Events;
using System.IO;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using iText.Kernel.Geom;

public class Program
{
    static void Main(string[] args)
    {
        string html = @"<p>The classes should be defined in CSS, otherwise no changes will be visible on the table&#39;s appearance.</p>

<table style=""width: 100%;"">
	<tbody>
		<tr>
			<td style=""width: 25%;"">
				<br>
			</td>
			<td style=""width: 25%;"">
				<br>
			</td>
			<td style=""width: 25%;"">
				<br>
			</td>
			<td style=""width: 25%;"">
				<br>
			</td>
		</tr>
		<tr>
			<td style=""width: 25%;"">
				<br>
			</td>
			<td style=""width: 25%;"">
				<br>
			</td>
			<td style=""width: 25%;"">
				<br>
			</td>
			<td style=""width: 25%;"">
				<br>
			</td>
		</tr>
	</tbody>
</table>

<p>
	<br>
</p>

<p>555555555555555</p>

<p><img src=""https://i.froala.com/assets/photo1.jpg"" data-id=""1"" data-type=""image"" data-name=""Image 2023-09-06 at 22:09:57.jpg"" alt=""Image 2023-09-06 at 22:09:57.jpg"" data-tag=""beach"" data-url=""https://i.froala.com/assets/photo1.jpg"" style=""width: 300px;"" class=""fr-fic fr-dib""></p>

<p>appearance</p>

<p><img src=""https://i.froala.com/assets/photo1.jpg"" data-id=""1"" data-type=""image"" data-name=""Image 2023-10-10 at 14:10:04.jpg"" alt=""Image 2023-10-10 at 14:10:04.jpg"" data-tag=""beach"" data-url=""https://i.froala.com/assets/photo1.jpg"" style=""width: 300px;"" class=""fr-fic fr-dib""></p>

<p><img src=""https://i.froala.com/assets/photo1.jpg"" data-id=""1"" data-type=""image"" data-name=""Image 2023-09-01 at 00:09:55.jpg"" alt=""Image 2023-09-01 at 00:09:55.jpg"" data-tag=""beach"" data-url=""https://i.froala.com/assets/photo1.jpg"" style=""width: 300px;"" class=""fr-fic fr-dib""></p>

<p>
	<br>
</p>

<p><img src=""https://i.froala.com/assets/photo1.jpg"" data-id=""1"" data-type=""image"" data-name=""Image 2023-10-01 at 04:10:10.jpg"" alt=""Image 2023-10-01 at 04:10:10.jpg"" data-tag=""beach"" data-url=""https://i.froala.com/assets/photo1.jpg"" style=""width: 300px;"" class=""fr-fic fr-dib""></p>

<p><img src=""https://i.froala.com/assets/photo1.jpg"" data-id=""1"" data-type=""image"" data-name=""Image 2023-10-26 at 22:10:14.jpg"" alt=""Image 2023-10-26 at 22:10:14.jpg"" data-tag=""beach"" data-url=""https://i.froala.com/assets/photo1.jpg"" style=""width: 300px;"" class=""fr-fic fr-dib""></p>

<p>
	<br>
</p>

<p>appearance</p>

<table style=""width: 100%;"">
	<tbody>
		<tr>
			<td style=""width: 9.9589%;"">
				<br><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span></td>
			<td style=""width: 9.959%;""><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span>
				<br>
			</td>
			<td style=""width: 10.0000%;""><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span>
				<br>
			</td>
			<td style=""width: 10.0000%;""><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span>
				<br>
			</td>
			<td style=""width: 10.0000%;""><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span>
				<br>
			</td>
			<td style=""width: 10.0000%;""><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span>
				<br>
			</td>
			<td style=""width: 10.0000%;""><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span>
				<br>
			</td>
			<td style=""width: 10.0000%;""><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span>
				<br>
			</td>
			<td style=""width: 10.0000%;""><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span>
				<br>
			</td>
			<td style=""width: 10.0000%;""><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span>
				<br>
			</td>
		</tr>
		<tr>
			<td style=""width: 9.9589%;""><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span>
				<br>
			</td>
			<td style=""width: 9.959%;""><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span>
				<br>
			</td>
			<td style=""width: 10.0000%;""><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span>
				<br>
			</td>
			<td style=""width: 10.0000%;""><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span>
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;""><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span>
				<br>
			</td>
		</tr>
		<tr>
			<td style=""width: 9.9589%;"">
				<br><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span></td>
			<td style=""width: 9.959%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span></td>
		</tr>
		<tr>
			<td style=""width: 9.9589%;"">
				<br><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span></td>
			<td style=""width: 9.959%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span></td>
		</tr>
		<tr>
			<td style=""width: 9.9589%;"">
				<br><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span></td>
			<td style=""width: 9.959%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span></td>
		</tr>
		<tr>
			<td style=""width: 9.9589%;"">
				<br><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span></td>
			<td style=""width: 9.959%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span></td>
		</tr>
		<tr>
			<td style=""width: 9.9589%;"">
				<br><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span></td>
			<td style=""width: 9.959%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;""><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span>
				<br>
			</td>
		</tr>
		<tr>
			<td style=""width: 9.9589%;"">
				<br><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span></td>
			<td style=""width: 9.959%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
		</tr>
		<tr>
			<td style=""width: 9.9589%;"">
				<br><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span></td>
			<td style=""width: 9.959%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
		</tr>
		<tr>
			<td style=""width: 9.9589%;""><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span>
				<br>
			</td>
			<td style=""width: 9.959%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;"">
				<br>
			</td>
			<td style=""width: 10.0000%;""><span style=""color: rgb(53, 53, 53); font-family: Nunito, Nunito; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"" id=""isPasted"">plugin</span>
				<br>
				<br>
				<br>
			</td>
		</tr>
	</tbody>
</table>
<div data-aura-rendered-by=""22:215;a"" data-aura-class=""forceChatterFeedBodyQuestionWithoutAnswer"" style=""box-sizing: border-box; font-weight: bold; overflow-wrap: break-word; outline: 0px; margin-bottom: var(--lwc-varSpacingMedium,1rem); font-family: var(--lwc-fontFamilyStrong,BentonSans-Bold); font-size: var(--lwc-fcFontSizeLarge,1rem); color: rgb(51, 51, 51); font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial;"" id=""isPasted""><span data-aura-rendered-by=""25:215;a"" data-aura-class=""uiOutputText"" style=""box-sizing: border-box;"">Sample - Superstore Sales (Excel).xls</span></div>
<div data-aura-rendered-by=""26:215;a"" data-aura-class=""forceChatterFeedBodyQuestionWithoutAnswer"" style=""box-sizing: border-box; outline: 0px; margin-bottom: var(--lwc-varSpacingMedium,1rem); color: rgb(51, 51, 51); font-family: BentonSans-Book; font-size: 13px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial;"">
	<div data-aura-rendered-by=""30:215;a"" data-aura-class=""forceChatterMessageSegments forceChatterFeedBodyText"" style=""box-sizing: border-box; overflow-wrap: break-word; line-height: var(--lwc-lineHeightText,1.5); position: relative; user-select: auto;"">
		<div style=""box-sizing: border-box;"">

			<p style=""box-sizing: border-box; margin: 0px; padding: 0px; font-family: BentonSans-Regular, sans-serif; line-height: 1.88; font-size: 16px;""><span dir=""ltr"" style=""box-sizing: border-box;"">Sample data that appears in the December Tableau User Group presentation. Note: Geographic locations have been altered to include Canadian locations (provinces / regions).</span></p>

			<p style=""box-sizing: border-box; margin: 0px; padding: 0px; font-family: BentonSans-Regular, sans-serif; line-height: 1.88; font-size: 16px;"">
				<br>
			</p>&nbsp;

			<table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""716"" style=""border-collapse: collapse;width:538pt;"" id=""isPasted"">
				<tbody>
					<tr>
						<td height=""21"" class=""xl77"" width=""38.8268156424581%"" style=""color:black;font-size:16px;font-weight:700;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:left;vertical-align:bottom;border:none;height:15.6pt;width:209pt;"">SMART goal setting</td>
						<td class=""xl73"" width=""61.1731843575419%"" style=""color:black;font-size:12px;font-weight:400;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:general;vertical-align:bottom;border:none;width:329pt;"">
							<br>
						</td>
					</tr>
					<tr>
						<td height=""19"" class=""xl78"" style=""color:black;font-size:15px;font-weight:700;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:left;vertical-align:bottom;border:.5pt solid windowtext;height:14.4pt;"">S</td>
						<td class=""xl76"" style=""color:black;font-size:12px;font-weight:400;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:general;vertical-align:bottom;border:.5pt solid windowtext;border-left:none;"">Specific</td>
					</tr>
					<tr>
						<td height=""19"" class=""xl78"" style=""color:black;font-size:15px;font-weight:700;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:left;vertical-align:bottom;border:.5pt solid windowtext;height:14.4pt;border-top:none;"">M</td>
						<td class=""xl76"" style=""color:black;font-size:12px;font-weight:400;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:general;vertical-align:bottom;border:.5pt solid windowtext;border-top:none;border-left:none;"">Measurable</td>
					</tr>
					<tr>
						<td height=""19"" class=""xl78"" style=""color:black;font-size:15px;font-weight:700;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:left;vertical-align:bottom;border:.5pt solid windowtext;height:14.4pt;border-top:none;"">A</td>
						<td class=""xl76"" style=""color:black;font-size:12px;font-weight:400;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:general;vertical-align:bottom;border:.5pt solid windowtext;border-top:none;border-left:none;"">Achievable</td>
					</tr>
					<tr>
						<td height=""19"" class=""xl78"" style=""color:black;font-size:15px;font-weight:700;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:left;vertical-align:bottom;border:.5pt solid windowtext;height:14.4pt;border-top:none;"">R</td>
						<td class=""xl76"" style=""color:black;font-size:12px;font-weight:400;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:general;vertical-align:bottom;border:.5pt solid windowtext;border-top:none;border-left:none;"">Realistic</td>
					</tr>
					<tr>
						<td height=""19"" class=""xl78"" style=""color:black;font-size:15px;font-weight:700;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:left;vertical-align:bottom;border:.5pt solid windowtext;height:14.4pt;border-top:none;"">T</td>
						<td class=""xl76"" style=""color:black;font-size:12px;font-weight:400;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:general;vertical-align:bottom;border:.5pt solid windowtext;border-top:none;border-left:none;"">Timebound</td>
					</tr>
					<tr>
						<td height=""17"" class=""xl75"" style=""color:black;font-size:12px;font-weight:400;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:left;vertical-align:middle;border:none;height:12.6pt;"">
							<br>
						</td>
						<td class=""xl74"" style=""color:black;font-size:12px;font-weight:400;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:left;vertical-align:bottom;border:none;width:329pt;"">
							<br>
						</td>
					</tr>
					<tr>
						<td height=""16"" class=""xl79"" style=""color:black;font-size:12px;font-weight:700;font-style:normal;text-decoration:none;font-family:Arial, sans-serif;text-align:left;vertical-align:bottom;border:none;border-top:1.0pt solid windowtext;border-right:.5pt solid windowtext;border-bottom:.5pt solid windowtext;border-left:1.0pt solid windowtext;background:#BFBFBF;height:12.0pt;"">Rating</td>
						<td class=""xl71"" style=""color:black;font-size:12px;font-weight:700;font-style:normal;text-decoration:none;font-family:Arial, sans-serif;text-align:left;vertical-align:bottom;border:none;border-top:1.0pt solid windowtext;border-right:1.0pt solid windowtext;border-bottom:.5pt solid windowtext;border-left:none;background:#BFBFBF;"">Rating Description</td>
					</tr>
					<tr>
						<td height=""16"" class=""xl80"" width=""38.8268156424581%"" style=""color:white;font-size:12px;font-weight:700;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:left;vertical-align:middle;border:.5pt solid windowtext;background:#0070C0;height:12.0pt;border-top:none;width:209pt;"">5</td>
						<td class=""xl72"" width=""61.1731843575419%"" style=""color:black;font-size:12px;font-weight:400;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:left;vertical-align:bottom;border:none;border-top:none;border-right:1.0pt solid windowtext;border-bottom:.5pt solid windowtext;border-left:none;width:329pt;"">Out Standing Performance&nbsp;</td>
					</tr>
					<tr>
						<td height=""16"" class=""xl81"" width=""38.8268156424581%"" style=""color:white;font-size:12px;font-weight:700;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:left;vertical-align:middle;border:.5pt solid windowtext;background:#00B050;height:12.0pt;border-top:none;width:209pt;"">4</td>
						<td class=""xl72"" width=""61.1731843575419%"" style=""color:black;font-size:12px;font-weight:400;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:left;vertical-align:bottom;border:none;border-top:none;border-right:1.0pt solid windowtext;border-bottom:.5pt solid windowtext;border-left:none;width:329pt;"">Above Expectations</td>
					</tr>
					<tr>
						<td height=""16"" class=""xl82"" width=""38.8268156424581%"" style=""color:white;font-size:12px;font-weight:700;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:left;vertical-align:middle;border:.5pt solid windowtext;background:#92D050;height:12.0pt;border-top:none;width:209pt;"">3</td>
						<td class=""xl72"" width=""61.1731843575419%"" style=""color:black;font-size:12px;font-weight:400;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:left;vertical-align:bottom;border:none;border-top:none;border-right:1.0pt solid windowtext;border-bottom:.5pt solid windowtext;border-left:none;width:329pt;"">Meets Expectations</td>
					</tr>
					<tr>
						<td height=""16"" class=""xl83"" width=""38.8268156424581%"" style=""color:white;font-size:12px;font-weight:700;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:left;vertical-align:middle;border:.5pt solid windowtext;background:#FFC000;height:12.0pt;border-top:none;width:209pt;"">2</td>
						<td class=""xl72"" width=""61.1731843575419%"" style=""color:black;font-size:12px;font-weight:400;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:left;vertical-align:bottom;border:none;border-top:none;border-right:1.0pt solid windowtext;border-bottom:.5pt solid windowtext;border-left:none;width:329pt;"">Needs areas of Improvements</td>
					</tr>
					<tr>
						<td height=""16"" class=""xl84"" width=""38.8268156424581%"" style=""color:white;font-size:12px;font-weight:700;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:left;vertical-align:middle;border:.5pt solid windowtext;background:#ED7D31;height:12.0pt;border-top:none;width:209pt;"">Too New To Rate&nbsp;</td>
						<td class=""xl85"" width=""61.1731843575419%"" style=""color:black;font-size:12px;font-weight:400;font-style:normal;text-decoration:none;font-family:Calibri, sans-serif;text-align:left;vertical-align:bottom;border:.5pt solid windowtext;border-top:none;border-left:none;width:329pt;"">New Joiner</td>
					</tr>
				</tbody>
			</table>
		</div></div></div>
";
        GeneratePdfWithHeaderAndFooter(html);
    }
        public static void GeneratePdfWithHeaderAndFooter(string htmlContent)
        {
            PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream("C:\\Users\\tns\\Documents\\NTF\\demo.pdf", FileMode.Create)));
            Document document = new Document(pdfDocument);

            // Define fonts and colors for header and footer
            PdfFont headerFooterFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            Color headerFooterColor = new DeviceRgb(0, 0, 0); // DeviceRgb for black color

            // Create a header event handler
            pdfDocument.AddEventHandler(PdfDocumentEvent.START_PAGE, new HeaderHandler(headerFooterFont, headerFooterColor));

            // Create a footer event handler
            pdfDocument.AddEventHandler(PdfDocumentEvent.END_PAGE, new FooterHandler(headerFooterFont, headerFooterColor));

            // Convert HTML content to PDF and add to the document
            HtmlConverter.ConvertToPdf(htmlContent, pdfDocument, null);

            // Close the document to save changes
            document.Close();
        }

    private class HeaderHandler : IEventHandler
    {
        private PdfFont font;
        private Color color;

        public HeaderHandler(PdfFont font, Color color)
        {
            this.font = font;
            this.color = color;
        }

        public void HandleEvent(Event @event)
        {
            PdfDocumentEvent docEvent = (PdfDocumentEvent)@event;
            PdfDocument pdfDoc = docEvent.GetDocument();
            PdfPage page = docEvent.GetPage();

            float x = page.GetPageSize().GetWidth() / 2;
            float y = page.GetPageSize().GetTop() - 30;

            new Canvas(page, new Rectangle(0, 0, page.GetPageSize().GetWidth(), page.GetPageSize().GetTop()))
                .SetFont(font)
                .SetFontSize(12)
                .SetFontColor(color)
                .ShowTextAligned("Header Content", x, y, TextAlignment.CENTER);
        }
    }

    private class FooterHandler : IEventHandler
    {
        private PdfFont font;
        private Color color;

        public FooterHandler(PdfFont font, Color color)
        {
            this.font = font;
            this.color = color;
        }

        public void HandleEvent(Event @event)
        {
            PdfDocumentEvent docEvent = (PdfDocumentEvent)@event;
            PdfDocument pdfDoc = docEvent.GetDocument();
            PdfPage page = docEvent.GetPage();

            float x = page.GetPageSize().GetWidth() / 2;
            float y = 30;

            new Canvas(page, new Rectangle(0, 0, page.GetPageSize().GetWidth(), page.GetPageSize().GetBottom()))
                .SetFont(font)
                .SetFontSize(12)
                .SetFontColor(color)
                .ShowTextAligned("Footer Content", x, y, TextAlignment.CENTER);
        }
    }
}

    

