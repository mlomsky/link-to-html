using System.Diagnostics;
using System.Text.RegularExpressions;

namespace link_to_html
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static (string, string) ParseItem(string input)
        {
            var match = Regex.Match(input, @"\[(.*?)\]\((.*?)\)");
            if (match.Success)
            {
                return (match.Groups[1].Value, match.Groups[2].Value);
            }
            return ("", ""); // Return empty values if no match is found
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string inputFilePath = Path.Combine(desktopPath, "exporttab.txt");
            string linkPageTitleTxt = textBoxLinkPageTitle.Text;  // Get text from the text box

            if (!File.Exists(inputFilePath))
            {
                lblStatus.Text = "Error: 'exporttab.txt' not found!";
                MessageBox.Show("Error: 'exporttab.txt' not found on the desktop!", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<(string title, string url)> links = new List<(string, string)>();

            foreach (var line in File.ReadAllLines(inputFilePath))
            {
                var parts = ParseItem(line);
                if (parts.Item1 != "")
                {
                    links.Add((parts.Item1.Trim(), parts.Item2.Trim()));
                }
            }

            if (links.Count == 0)
            {
                lblStatus.Text = "No valid links found.";
                MessageBox.Show("No valid links found in 'exporttab.txt'. Please check the format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // string htmlContent = "<!DOCTYPE html>\n<html>\n<head>\n<title>Links Page</title>\n</head>\n<body>\n<ul>\n";
            string htmlContent = "<!DOCTYPE html>\n<html>\n<head>\n<meta http-equiv=\"content-type\" content=\"text/html; charset=ISO-8859-1\">" +
                                 "<title>" + linkPageTitleTxt + "</title>\n" +"<style>"+ "\nhtml * {\nfont-family: Calibri;\n}\n</style>\n</head>\n<body>\n" + 
                                 "<H1>" + linkPageTitleTxt + "</H1>\n";

            // Handle Link List
            htmlContent += "<ul>\n";
            foreach (var link in links)
            {
                htmlContent += $"<li><a href=\"{link.url}\" target=\"_blank\">{link.title}</a></li>\n";
            }
            htmlContent += "</ul>\n</body>\n</html>"; // Close up Link List

            string outputFilePath = Path.Combine(desktopPath, "links.html");
            File.WriteAllText(outputFilePath, htmlContent);

            lblStatus.Text = $"Done at {DateTime.Now:HH:mm:ss}";
            MessageBox.Show($"HTML file generated successfully!\nSaved at: {outputFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Open the HTML file in the default browser
            try
            {
                Process.Start(new ProcessStartInfo(outputFilePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open browser: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
