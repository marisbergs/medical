INSERT INTO Classifiers( CLS_ID, CLS_TYPE_ID, CLS_CODE, CLS_NAME, CLS_PARENT_ID)  
	SELECT NewId(), 'TemplateType', 'Letter', 'V�stule', CLS_ID FROM Classifiers WHERE CLS_TYPE_ID = 'TemplateGroup' AND CLS_CODE = 'Other'
