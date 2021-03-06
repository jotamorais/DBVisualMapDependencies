# DBVisualMapDependencies
This project aims to help developers and DBAs to see graphically, all database objects dependencies. It's built on top of [AspnetBoilerplate](http://aspnetboilerplate.com/) and [D3.js](http://d3js.org/).

# Requirements
1. To make it work, you first need to create a DB view like this one:
	```SQL
	CREATE VIEW [dbo].[vDBObjectDependencyMapping]
	AS
	SELECT 
		referencing.dbobject_id AS [Id],
		referencing.dbobject_schema AS [Schema],
		referencing.dbobject AS [Name],
		referencing.dbobject_type AS [Type],
		referenced.child_dbobject_id AS [ChildId],
		referenced.child_dbbobject_schema AS [ChildSchema],
		referenced.child_dbobject AS [ChildName],
		referenced.child_dbobject_type AS [ChildType]
	FROM
	(
		SELECT 
			[object_id] [dbobject_id],
			schema_name([schema_id]) [dbobject_schema],
			name [dbobject],
			type_desc [dbobject_type] 
		FROM 
			SYS.OBJECTS
		WHERE 
			[type] NOT IN ('D','IT','PK','SQ','UQ','U','S','TR')
	) 
	referencing
	LEFT OUTER JOIN
	(
		SELECT 
			id [parent_dbobject_id],
			depid [child_dbobject_id],
			schema_name([schema_id]) [child_dbbobject_schema],
			name [child_dbobject],
			type_desc [child_dbobject_type] 
		FROM 
			SYSDEPENDS 
		JOIN 
			SYS.OBJECTS
		ON 
			[object_id] = depid
		GROUP BY 
			id,
			depid,
			[schema_id],
			name,
			type_desc
	) 
	referenced
	ON 
		referencing.dbobject_id = referenced.parent_dbobject_id
	```

2. And point the connection string to the DB you want to visualize the dependencies
