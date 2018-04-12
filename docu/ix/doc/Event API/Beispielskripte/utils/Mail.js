/**
 * Helper function to send an email.
 */

/**
 * Import Java packages
 */
var importNamesMail = JavaImporter();
importNamesMail.importPackage(Packages.javax.mail);
importNamesMail.importPackage(Packages.javax.mail.internet);
importNamesMail.importPackage(Packages.java.util);
importNamesMail.importPackage(Packages.de.elo.utils.sec);

/**
 * Mail host.
 */
var mailHost = "192.168.1.11"; 

/**
 * Mail user name 
 */
var mailUser = "****";

/**
 * Mail user password.
 * Can be an encrypted string.
 * To encrypt a password use:  
 * String encryptedPassword = new de.elo.utils.sec.DesEncryption().encrypt(plaintextPassword);
 */
var mailPwd = "****";

/**
 * Send an email.
 * @param mailto Mail recipient
 * @param subject Mail subject
 * @param content Mail body
 */
function sendMail(mailto, subject, content) {
	with (importNamesMail) {
        var props = new Properties();
        
		props.setProperty("mail.transport.protocol", "smtp");
		props.setProperty("mail.host", mailHost);
		props.setProperty("mail.user", mailUser);
		props.setProperty("mail.password", new DesEncryption().decryptIfEncrypted(mailPwd));

        var mailSession = Session.getDefaultInstance(props, null);
        var transport = mailSession.getTransport();

        var message = new MimeMessage(mailSession);
        message.setSubject(subject);
        message.setContent(content, "text/plain");
        message.addRecipient(Message.RecipientType.TO,
                        new InternetAddress(mailto));

        transport.connect();
        transport.sendMessage(message,
                message.getRecipients(Message.RecipientType.TO));
        transport.close();
  }
}

