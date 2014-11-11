set nocount on

select 'set nocount on'

Declare @ieprieksejaas_versijas_datums datetime
set @ieprieksejaas_versijas_datums = '2006-10-25'

select 'if not exists (select * from BinaryFiles where BFI_ID=''' + CAST(BFI_ID as varchar(50)) + ''') ' +
  'insert into BinaryFiles(BFI_ID, BFI_NAME, BFI_CONTENT_ID) values (' +
  '''' + cast(BFI_ID as varchar(50)) + ''', ' +
  '''' + BFI_NAME + ''', ' +
  '''' + cast(BFI_CONTENT_ID as varchar(50)) + ''') '
from Templates inner join TemplateFileVersions
     on TPL_ID = TFV_TEMPLATE_ID
     inner join BinaryFiles
     on TFV_FILE_ID = BFI_ID
WHERE TFV__DELETE_TIME IS NULL
  AND TPL__DELETE_TIME IS NULL
  AND Len(TPL_CODE) = 4
  AND TFV__UPDATE_TIME > @ieprieksejaas_versijas_datums

select distinct 'if not exists (select * from Templates where TPL_ID=''' + CAST(TPL_ID as varchar(50)) + ''') ' +
  'insert into Templates(TPL_ID, TPL_TYPE_ID, TPL_CODE, TPL_NAME, TPL_DESCRIPTION, TPL_VALID_FROM, TPL_VALID_UNTIL) values (' +
  '''' + cast(TPL_ID as varchar(50)) + ''', ' +
  '''' + cast(TPL_TYPE_ID as varchar(50)) + ''', ' +
  '''' + TPL_CODE + ''', ' +
  '''' + TPL_NAME + ''', ' +
  IsNull('''' + TPL_DESCRIPTION + '''', 'NULL') + ', ' +
  '''' + convert(varchar, TPL_VALID_FROM, 126) + ''', ' +
  IsNull('''' + convert(varchar, TPL_VALID_UNTIL, 126) + '''', 'NULL') + ') ' +
  'else ' +
  'UPDATE Templates ' +
  ' SET TPL_CODE = ''' + TPL_CODE + ''', ' +
  ' TPL_NAME = ''' + TPL_NAME + ''', ' +
  ' TPL_DESCRIPTION = ' + IsNull('''' + TPL_DESCRIPTION + '''', 'NULL') + ', ' +
  ' TPL_VALID_FROM = ''' + convert(varchar, TPL_VALID_FROM, 126) + ''', ' +
  ' TPL_VALID_UNTIL = ' + IsNull('''' + convert(varchar, TPL_VALID_UNTIL, 126) + '''', 'NULL') +
  ' WHERE TPL_ID = ''' + cast(TPL_ID as varchar(50)) + ''''
from Templates inner join TemplateFileVersions
     on TPL_ID = TFV_TEMPLATE_ID
     inner join BinaryFiles
     on TFV_FILE_ID = BFI_ID
WHERE TFV__DELETE_TIME IS NULL
  AND TPL__DELETE_TIME IS NULL
  AND Len(TPL_CODE) = 4
  AND TFV__UPDATE_TIME > @ieprieksejaas_versijas_datums

select 'if not exists (select * from TemplateFileVersions where TFV_ID=''' + CAST(TFV_ID as varchar(50)) + ''') begin ' +
  'insert into TemplateFileVersions(TFV_ID, TFV_TEMPLATE_ID, TFV_VERSION_NUMBER, TFV_FILE_ID, TFV_COMMENT, TFV_VALID_FROM, TFV_VALID_UNTIL) values (' +
  '''' + cast(TFV_ID as varchar(50)) + ''', ' +
  '''' + cast(TFV_TEMPLATE_ID as varchar(50)) + ''', ' +
  '''' + cast(TFV_VERSION_NUMBER as varchar(5)) + ''', ' +
  '''' + cast(TFV_FILE_ID as varchar(50)) + ''', ' +
  IsNull('''' + TFV_COMMENT + '''', 'NULL') + ', ' +
  '''' + convert(varchar, TFV_VALID_FROM, 126) + ''', ' +
  IsNull('''' + convert(varchar, TFV_VALID_UNTIL, 126) + '''', 'NULL') + ') ' +
  'UPDATE TemplateFileVersions' +
  ' SET TFV__DELETE_TIME = getdate()' +
  ' WHERE TFV_TEMPLATE_ID = ''' + cast(TFV_TEMPLATE_ID as varchar(50)) + '''' +
  ' AND TFV_ID <> ''' + cast(TFV_ID as varchar(50)) + ''' end'
from Templates inner join TemplateFileVersions
     on TPL_ID = TFV_TEMPLATE_ID
     inner join BinaryFiles
     on TFV_FILE_ID = BFI_ID
WHERE TFV__DELETE_TIME IS NULL
  AND TPL__DELETE_TIME IS NULL
  AND Len(TPL_CODE) = 4
  AND TFV__UPDATE_TIME > @ieprieksejaas_versijas_datums
ORDER BY TFV_TEMPLATE_ID, TFV_VERSION_NUMBER

select 'if not exists (select * from ClassifierTypes where CLT_ID=''' + CLT_ID + ''') begin ' +
  'insert into ClassifierTypes(CLT_ID, CLT_NAME, CLT_KIND, CLT_FORM, CLT__DELETE_TIME, CLT_VALUE_PROMPT, CTL_DECIMAL_PLACE, CTL_REFERENCE_ID_SECOND, CLT_CODE_PROMPT, CLT_MEMO_PROMPT, CLT_NUMBER_PROMPT, CLT_LOOKUP_ID, CLT_MARK_PROMPT) values (' +
  '''' + CLT_ID + ''', ' +
  '''' + CLT_NAME + ''', ' +
  '''' + cast(CLT_KIND as varchar(5)) + ''', ' +
  IsNull('''' + CLT_FORM + '''', 'NULL') + ', ' +
  IsNull('''' + convert(varchar, CLT__DELETE_TIME, 126) + '''', 'NULL') + ', ' +
  IsNull('''' + CLT_VALUE_PROMPT + '''', 'NULL') + ', ' +
  IsNull('''' + CTL_DECIMAL_PLACE + '''', 'NULL') + ', ' +
  IsNull('''' + CTL_REFERENCE_ID_SECOND + '''', 'NULL') + ', ' +
  IsNull('''' + CLT_CODE_PROMPT + '''', 'NULL') + ', ' +
  IsNull('''' + CLT_MEMO_PROMPT + '''', 'NULL') + ', ' +
  IsNull('''' + CLT_NUMBER_PROMPT + '''', 'NULL') + ', ' +
  IsNull('''' + CLT_LOOKUP_ID + '''', 'NULL') + ', ' +
  IsNull('''' + CLT_MARK_PROMPT + '''', 'NULL') + ') ' +
  ' end else begin ' +
  'UPDATE ClassifierTypes ' +
  ' SET CLT_NAME = ''' + Replace(CLT_NAME, '''', '''''') + ''', ' +
  ' CLT_KIND = ' + cast(CLT_KIND as varchar) + ', ' +
  ' CLT_FORM = ' + IsNull('''' + Replace(CLT_FORM, '''', '''''') + '''', 'NULL') + ', ' +
  ' CLT__DELETE_TIME = ' + IsNull('''' +convert(varchar, CLT__DELETE_TIME, 126) + '''', 'NULL') + ', ' +
  ' CLT_VALUE_PROMPT = ' + IsNull('''' + Replace(CLT_VALUE_PROMPT, '''', '''''') + '''', 'NULL') + ', ' +
  ' CTL_DECIMAL_PLACE = ' + IsNull('''' + Replace(CTL_DECIMAL_PLACE, '''', '''''') + '''', 'NULL') + ', ' +
  ' CTL_REFERENCE_ID_SECOND = ' + IsNull('''' + Replace(CTL_REFERENCE_ID_SECOND, '''', '''''') + '''', 'NULL') + ', ' +
  ' CLT_CODE_PROMPT = ' + IsNull('''' + Replace(CLT_CODE_PROMPT, '''', '''''') + '''', 'NULL') + ', ' +
  ' CLT_MEMO_PROMPT = ' + IsNull('''' + Replace(CLT_MEMO_PROMPT, '''', '''''') + '''', 'NULL') + ', ' +
  ' CLT_NUMBER_PROMPT = ' + IsNull('''' + Replace(CLT_NUMBER_PROMPT, '''', '''''') + '''', 'NULL') + ', ' +
  ' CLT_LOOKUP_ID = ' + IsNull('''' + Replace(CLT_LOOKUP_ID, '''', '''''') + '''', 'NULL') + ', ' +
  ' CLT_MARK_PROMPT = ' + IsNull('''' + Replace(CLT_MARK_PROMPT, '''', '''''') + '''', 'NULL') +
  ' WHERE CLT_ID = ' + '''' + CLT_ID + '''' +
  ' end'
from ClassifierTypes

select 
  'UPDATE Classifiers ' +
  ' SET CLS_TYPE_ID = ''' + CLS_TYPE_ID + ''', ' +
  ' CLS_PARENT_ID = ' + IsNull('''' + cast(CLS_PARENT_ID as varchar(50)) + '''', 'NULL') + ', ' +
  ' CLS_NTEXT_ID = ' + IsNull('''' + cast(CLS_NTEXT_ID as varchar(50)) + '''', 'NULL') + ', ' +
  ' CLS_CODE = ' + IsNull('''' + Replace(CLS_CODE, '''', '''''') + '''', 'NULL') + ', ' +
  ' CLS_NAME = ''' + Replace(CLS_NAME, '''', '''''') + ''', ' +
  ' CLS_VALID_FROM = ' + IsNull('''' +convert(varchar, CLS_VALID_FROM, 126) + '''', 'NULL') + ', ' +
  ' CLS_VALID_UNTIL = ' + IsNull('''' + convert(varchar, CLS_VALID_UNTIL, 126) + '''', 'NULL') + ', ' + 
  ' CLS_TEXT = ' + IsNull('''' + Replace(CLS_TEXT, '''', '''''') + '''', 'NULL') + ', ' +
  ' CLS_DECIMAL = ' + IsNull(cast(CLS_DECIMAL as varchar(20)), 'NULL') + ', ' +
  ' CLS__EXTERNAL_ID = ' + IsNull('''' + cast(CLS__EXTERNAL_ID as varchar(20)) + '''', 'NULL') +
  ' WHERE CLS_ID = ' + '''' + cast(CLS_ID as varchar(50)) + ''''
from Classifiers
where CLS_TYPE_ID in ('AuditMessage', 'QualityCheck')
   OR (CLS_TYPE_ID = 'ActivityType' AND CLS__EXTERNAL_ID < 0) 
   OR (CLS_TYPE_ID = 'FuelType' AND CLS__EXTERNAL_ID < 0)
   OR (CLS_TYPE_ID ='TaxpayerInformed' AND CLS__EXTERNAL_ID < 0)
   OR (CLS_TYPE_ID ='WHReport' AND CLS__EXTERNAL_ID < 0)
   OR (CLS_TYPE_ID ='DocRequisite' AND CLS__EXTERNAL_ID < 0)
   OR (CLS_TYPE_ID ='TemplateType' AND CLS__EXTERNAL_ID < 0)
order by CLS_TYPE_ID


select 'if not exists (select * from Classifiers where CLS_ID=''' + CAST(CLS_ID as varchar(50)) + ''') ' +
  'insert into Classifiers(CLS_ID, CLS_TYPE_ID, CLS_PARENT_ID, CLS_NTEXT_ID, CLS_CODE, CLS_NAME, CLS_VALID_FROM, CLS_VALID_UNTIL, CLS_TEXT, CLS_DECIMAL, CLS__EXTERNAL_ID) values (' +
  '''' + cast(CLS_ID as varchar(50)) + ''', ' +
  '''' + CLS_TYPE_ID + ''', ' +
  IsNull('''' + cast(CLS_PARENT_ID as varchar(50)) + '''', 'NULL') + ', ' +
  IsNull('''' + cast(CLS_NTEXT_ID as varchar(50)) + '''', 'NULL') + ', ' +
  IsNull('''' + Replace(CLS_CODE, '''', '''''') + '''', 'NULL') + ', ' +
  '''' + Replace(CLS_NAME, '''', '''''') + ''', ' +
  IsNull('''' + convert(varchar, CLS_VALID_FROM, 126) + '''', 'NULL') + ', ' +
  IsNull('''' + convert(varchar, CLS_VALID_UNTIL, 126) + '''', 'NULL') + ', ' +
  IsNull('''' + Replace(CLS_TEXT, '''', '''''') + '''', 'NULL') + ', ' +
  IsNull('''' + cast(CLS__EXTERNAL_ID as varchar(20)) + '''', 'NULL') + ', ' +
  IsNull(cast(CLS_DECIMAL as varchar(20)), 'NULL') + ')'
from Classifiers
where CLS_TYPE_ID in ('AuditMessage', 'QualityCheck')
   OR (CLS_TYPE_ID = 'ActivityType' AND CLS__EXTERNAL_ID < 0) 
   OR (CLS_TYPE_ID = 'FuelType' AND CLS__EXTERNAL_ID < 0)
   OR (CLS_TYPE_ID ='TaxpayerInformed' AND CLS__EXTERNAL_ID < 0)
   OR (CLS_TYPE_ID ='WHReport' AND CLS__EXTERNAL_ID < 0)
   OR (CLS_TYPE_ID ='DocRequisite' AND CLS__EXTERNAL_ID < 0)
   OR (CLS_TYPE_ID ='TemplateType' AND CLS__EXTERNAL_ID < 0)
order by 1

--select 'delete from Permissions'

select 'if not exists (select * from Permissions where PRM_ID=''' + CAST(PRM_ID as varchar(50)) + ''') ' +
  'insert into Permissions(PRM_ID, PRM_MUTEX_GROUP, PRM_DESCRIPTION, PRM_CENTRAL_ONLY) values (' +
  '''' + PRM_ID + ''', ' +
  IsNull('''' + PRM_MUTEX_GROUP + '''', 'NULL') + ', ' +
  IsNull('''' + PRM_DESCRIPTION + '''', 'NULL') + ', ' +
  cast(PRM_CENTRAL_ONLY as varchar(1)) + ') ' +
  ' else ' +
  'UPDATE Permissions ' +
  ' SET PRM_MUTEX_GROUP = ' + IsNull('''' + PRM_MUTEX_GROUP + '''', 'NULL') + ', ' +
  ' PRM_DESCRIPTION = ' + IsNull('''' + PRM_DESCRIPTION + '''', 'NULL') + ', ' +
  ' PRM_CENTRAL_ONLY = ' + cast(PRM_CENTRAL_ONLY as varchar(1)) + 
  ' WHERE PRM_ID = ''' + cast(PRM_ID as varchar(50)) + ''''
from Permissions

--select 'if not exists (select * from RolesPermissions where RLP_ROLE_ID=''' + CAST(RLP_ROLE_ID as varchar(50)) + ''' AND RLP_PERMISSION_ID = ''' + RLP_PERMISSION_ID + ''') ' +
  --'insert into RolesPermissions(RLP_ROLE_ID, RLP_PERMISSION_ID) values (' +
  --'''' + Cast(RLP_ROLE_ID as varchar(50)) + ''', ' +
  --'''' + RLP_PERMISSION_ID + ''') '
--  ' else ' +
--  'DELETE FROM RolesPermissions ' +
--  ' WHERE RLP_ROLE_ID = ''' + cast(RLP_ROLE_ID as varchar(50)) + '''' +
--  ' AND RLP_PERMISSION_ID = ''' + RLP_PERMISSION_ID + ''''
--from RolesPermissions
--where RLP_ROLE_ID in (
--'819D6F92-8E66-43A9-B3F3-15057FA61B0D',
--'D86C1F92-3246-4ABB-A016-1B702EE4110C',
--'6DCE3C98-5BBC-49AB-8054-28642B5F3CF3',
--'6FCDC07B-4245-4F06-9CAF-5D1AABE3BDE0',
--'44D2FEF3-1F17-4073-807A-C89C26052BFD',
--'3DB6296A-EA4F-490B-9C8B-E13E1B8AAF48',
--'C20C01EF-1F21-4457-AABA-9804016757BA')

SELECT 'UPDATE _SynchroData SET SYD_LAST_SEND_SUCCESS=-1, SYD_LAST_RECV_SUCCESS = -1' 