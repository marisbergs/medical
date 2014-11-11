Option Explicit
Dim cmd, oshell, cd
Set oshell = CreateObject("WScript.Shell")

cd = oshell.CurrentDirectory

if CreateScriptFile("insertBinaryContent.sql", "tmp.sql") <> 0 then
  MsgBox "Neizdevâs izveidot failu tmp.sql! " & err.Description
  WScript.Quit
end if

cmd = "osql -S TTPAIS -d TPAIS -E -i tmp.sql -o err.log"
If oshell.Run(cmd,1,true) <> 0 Then WScript.Quit(3)

if CreateScriptFile("insertTextContent.sql", "tmp.sql") <> 0 then
  MsgBox "Neizdevâs izveidot failu tmp.sql! " & err.Description
  WScript.Quit
end if

cmd = "osql -S TTPAIS -d TPAIS -E -i tmp.sql -o err1.log"
If oshell.Run(cmd,1,true) <> 0 Then WScript.Quit(3)

msgbox "Instalâcija veikmîgi beigusies!"
Wscript.Quit

Function CreateScriptFile(ByVal tmplfile, ByVal scrfile)
  '===== atver Template failu
  '===== raksta izveidoto skriptu failâ
  Dim fso, fr, fw
  Dim r, s

  CreateScriptFile = -1
  On Error Resume Next
  Set fso = CreateObject("Scripting.FileSystemObject")
  Set fr = fso.OpenTextFile(tmplfile, 1, False, 0)
  if err.Number <> 0 then
    MsgBox "Kïûda atverot failu '" & tmplfile & "'" & chr(10) & err.Description
    Exit Function
  end if
  Set fw = fso.CreateTextFile(scrfile, True, False)
  if err.Number <> 0 then
    MsgBox "Kïûda veidojot failu '" & scrfile & "'" & chr(10) & err.Description
    Exit Function
  end if
  Set r = new RegExp
  Do While not fr.AtEndOfStream
    s = ReplaceString(r, fr.ReadLine, "%path%", cd)
    fw.WriteLine(s)
  Loop
  Set fr = Nothing
  Set fw = Nothing
  Set fso = Nothing
  Set r = Nothing
  CreateScriptFile = err.number
End Function

Function ReplaceString(ByRef r, ByVal str, ByVal ptrn, ByVal rplStr)
  r.Pattern = ptrn
  r.IgnoreCase = False
  r.Global = True
  ReplaceString = r.Replace (str, rplStr)
End Function

Function CreateFile(ByVal path, ByVal name, ByVal txt)
  Dim fso, fl
  err.Clear
  Set fso = CreateObject("Scripting.FileSystemObject")
  Set fl = fso.CreateTextFile(fso.BuildPath(path, name), True)
  fl.Write(txt)
  fl.Close
  Set fl = Nothing
  Set fso = Nothing
  CreateFile = err.Number
End Function
