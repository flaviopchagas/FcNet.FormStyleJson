# FcNet.FormStyleJson

Json Sample:

{
  "Panel": {
    "BorderStyle": "None"
  },
  "Button": {
    "BackColor": "#000000",
    "ForeColor": "#FFFFFF",
    "MouseOverBackColor": "#357CA5"
  },
  "pnlTitle": {
    "BackColor": "#3C8DBC",
    "ForeColor": "#000000",
    "Font": "Microsoft Sans Serif; 9; 0; 0",
    "BackgroundImage": "",
    "BackgroundImageLayout": "",
    "BorderStyle": "None",
    "Size": "200; 50",
    "Dock": "Top",
    "Padding": "0; 0; 0; 0"
  },
  "pnlLeft": {
    "BackColor": "#222D32",
    "Size": "250; 50",
    "Dock": "Left"
  },
  "pnlContent": {
    "BackColor": "#ECF0F5",
    "Dock": "Fill"
  },
  "btnOk,btnCancel": {
    "BackColor": "#000000",
    "ForeColor": "#FFFFFF",
    "MouseOverBackColor": "#357CA5"
  }
}

Instance Sample:

  public FormMain()
  {
      InitializeComponent();
      ThemeEngine.ApplyTheme(this);
  }
