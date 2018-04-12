ELO Business Solutions - SQL Scripts
------------------------------------

Note for DB2 and Oracle:

The DB2 and Oracle table names must be prefixed by the schema name. Please replace the schema name "Solution" by the schema name of the repository.

Example:

    CREATE TABLE Demo.sol_accounting_costcenter (company_code VARCHAR(20) NOT NULL, no VARCHAR(20) NOT NULL, name VARCHAR(100) NOT NULL, PRIMARY KEY (company_code, no));

Replace schema name:

    CREATE TABLE Repository1.sol_accounting_costcenter (company_code VARCHAR(20) NOT NULL, no VARCHAR(20) NOT NULL, name VARCHAR(100) NOT NULL, PRIMARY KEY (company_code, no));
 
 