   M S B A M L   `   `   `  ���� L  HSignalRChatClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SignalRChatClientSignalRChatClient  "    SignalRChatClient.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:SignalRChatClient       � Title$  SignalR Chat WPF Client��$	��436��$	��782��.��� $��0,0,193.333,50.667q� � ColumnDefinitions �� $
��109* ��� $
��288* �.+��� -    ��Name$ connectButton��$��Connect��$
��Left=�$��275.333,63,0,0q�$	��Top=�$��95��$��41��$��1���� -   $ 
sendButton��$��Send Message��$
��Left=�$��275.333,113,0,0q�$	��Top=�$��95��$��41��$��1��{�.  �� -    ��Name$ messageTextBox��$
��Left=�$��41��$��
82,113,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��311��$��2���� -    ��Name$ messagesList��$
��Left=�$	��141��$��
82,170,0,0q�$	��Top=�$	��311�� J� RenderTransformOrigin$ -0.304,0.109&�$��1q�$��2��
��������� -   $ userTextBox��$
��Left=�$��41��$��	82,57,0,0q�$
 Wrap=�$	��Top=�$	��311��$��2���� $
��User��$
��Left=�$��31��$��	39,63,0,0q�$	��Top=�$��38���� $��Message��$
��Left=�$��26��$��
19,120,0,0q�$	��Top=�$��58��