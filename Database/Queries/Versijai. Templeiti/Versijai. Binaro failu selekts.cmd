bcp "select BCO_ID, BCO_CONTENT from TPAIS.dbo.Templates inner join TPAIS.dbo.TemplateFileVersions on TPL_ID = TFV_TEMPLATE_ID inner join TPAIS.dbo.BinaryFiles on TFV_FILE_ID = BFI_ID inner join TPAIS.dbo.BinaryContent on BFI_CONTENT_ID = BCO_ID WHERE TFV__DELETE_TIME IS NULL AND TPL__DELETE_TIME IS NULL AND Len(TPL_CODE) = 4 AND TFV__UPDATE_TIME > '2006-10-25'" queryout res.bin -S zeus\tpais -T