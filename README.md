# Answer me these questions three (bonus points if you know what movie this quote is from)

1. **Salesforce POSTMAN**<br/>
Go to this [repo](https://github.com/forcedotcom/postman-salesforce-apis) and [download](https://github.com/forcedotcom/postman-salesforce-apis) the SF POSTMAN collection. Once you have imported the collection, perform the `SOAP Login` API call under the `Auth` folder in the collection. This API Call should be done against your Developer Edition Org you signed up for ([Support Doc 1](https://developer.salesforce.com/docs/atlas.en-us.api.meta/api/sforce_api_calls_login.htm) [Support Doc 2](https://trailhead.salesforce.com/content/learn/modules/api_basics/api_basics_soap)). Once you have successfully authenticated,set the following variables in the POSTMAN environment `Salesforce Template Environment`
    * `_accessToken` from `sessionId` in response
    * `_endpoint` from `serverUrl` in response (domain only)

   Once you have done this, perform the `Versions` API call under the `REST` folder. After you get the response back, create a new branch and create a file called `versions.json` and paste the result into that file

2. **Calculator**<br/>
   In whatever language you feel most comfortable with, write a small class that implements the following methods (On the same branch you created above, create the file that has this code):

   * `Integer add(Integer,Integer)
   * `Integer subtract(Integer,Integer)
   * `Integer multiply(Integer,Integer)
   * `String divide(Integer,Integer)
      * Example form of answer for 5/3 -> `1 R2`
      
3. **New Object Config and Build**<br/>
   As a Account Manager, I need to know how how many invoices that are not expired for each account, so that I know which account records are current. 
   Acceptance Criteria:
   * confirm a new object is created called invoice that is related to the Account object
   * confirm there is a field called Invoice Due Date, that is of type date, on the Invoice object
   * confirm there is a field called Invoice Amount, that is of type currency, on the Invoice object
   * confirm there is a field called Current Invoice Count on the Account object, of type number.
   * confirm that the Current Invoice Count field on the Account object show's ALL invoice records associated with that Account record, where the Invoice Due Date is greater than or equal to TODAY
   * confirm that the Current Invoice Count field is calculated every time a user queries, or opens/reads, the Account record

4. **Standard Object Config and Build**<br/>
   As an Account Manager, I need to know how many cases are opened accounts my Account records, so that I can better manage issue escalation. 
   Acceptance Criteria:
   * confirm there is a field on the Account object, called Open Cases, of type number.
   * confirm that whenever a case record is opened, and is associated to an Account record, a calculation is performed for all Cases related to that Account record, where the Case status does NOT equal "Closed" and that value is written to the Open Cases field.
   * confirm that whenever a case record is set to Closed, and is associated to an Account record, a calculation is performed for all Cases related to that Account record, where the case status does not equal "Closed" and that value is written to the Open Cases field.

