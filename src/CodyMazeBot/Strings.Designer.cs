﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodyMazeBot {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CodyMazeBot.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 👀 In che direzione stai guardando?.
        /// </summary>
        public static string AcceptCoordinateWaitForDirection {
            get {
                return ResourceManager.GetString("AcceptCoordinateWaitForDirection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 🟡.
        /// </summary>
        public static string AnswerCode1 {
            get {
                return ResourceManager.GetString("AnswerCode1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 🟢.
        /// </summary>
        public static string AnswerCode2 {
            get {
                return ResourceManager.GetString("AnswerCode2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 🔴.
        /// </summary>
        public static string AnswerCode3 {
            get {
                return ResourceManager.GetString("AnswerCode3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 🔢 Esegui le seguenti istruzioni e poi scansiona il codice QR sul quale ti fermi:
        ///
        ///&lt;code&gt;{0}&lt;/code&gt;.
        /// </summary>
        public static string AssignCode {
            get {
                return ResourceManager.GetString("AssignCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ❓ &lt;b&gt;{0}&lt;/b&gt;
        ///{1}
        ///
        ///🟡 {2}
        ///🟢 {3}
        ///🔴 {4}.
        /// </summary>
        public static string AssignQuiz {
            get {
                return ResourceManager.GetString("AssignQuiz", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scusa, non ho capito..
        /// </summary>
        public static string CannotHandle {
            get {
                return ResourceManager.GetString("CannotHandle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 📃 &lt;b&gt;Certificato&lt;/b&gt;
        ///Scrivimi il tuo nome completo per la generazione del certificato..
        /// </summary>
        public static string CertificateAskForName {
            get {
                return ResourceManager.GetString("CertificateAskForName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OK. Scrivimi il tuo nome completo..
        /// </summary>
        public static string CertificateAskForNameAgain {
            get {
                return ResourceManager.GetString("CertificateAskForNameAgain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Il tuo nome è &lt;i&gt;“{0}”&lt;/i&gt;. È corretto?.
        /// </summary>
        public static string CertificateAskForNameConfirmation {
            get {
                return ResourceManager.GetString("CertificateAskForNameConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Il nome non mi sembra valido, mi puoi scrivere il tuo nome completo?.
        /// </summary>
        public static string CertificateAskForNameInvalid {
            get {
                return ResourceManager.GetString("CertificateAskForNameInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Il tuo certificato di completamento di CodyMaze.
        /// </summary>
        public static string CertificateGenerationCaption {
            get {
                return ResourceManager.GetString("CertificateGenerationCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ha completato con successo l’attività di “Hour of Code” con CodyMaze, effettuando l’interpretazione di sequenze di codice, tra cui istruzioni elementari, condizionali e ripetizioni..
        /// </summary>
        public static string CertificateGenerationDescription {
            get {
                return ResourceManager.GetString("CertificateGenerationDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ✒ Sto generando il tuo certificato....
        /// </summary>
        public static string CertificateGenerationProcessing {
            get {
                return ResourceManager.GetString("CertificateGenerationProcessing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to D.
        /// </summary>
        public static string CertificateGenerationReleaseDateFormat {
            get {
                return ResourceManager.GetString("CertificateGenerationReleaseDateFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rilasciato il.
        /// </summary>
        public static string CertificateGenerationReleasedOn {
            get {
                return ResourceManager.GetString("CertificateGenerationReleasedOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificato di completamento.
        /// </summary>
        public static string CertificateGenerationTitle {
            get {
                return ResourceManager.GetString("CertificateGenerationTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to altrimenti.
        /// </summary>
        public static string CodeElse {
            get {
                return ResourceManager.GetString("CodeElse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to a.
        /// </summary>
        public static string CodeForward {
            get {
                return ResourceManager.GetString("CodeForward", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to se.
        /// </summary>
        public static string CodeIf {
            get {
                return ResourceManager.GetString("CodeIf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to s.
        /// </summary>
        public static string CodeLeft {
            get {
                return ResourceManager.GetString("CodeLeft", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to no stella.
        /// </summary>
        public static string CodeNoStar {
            get {
                return ResourceManager.GetString("CodeNoStar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to strada davanti.
        /// </summary>
        public static string CodePathAhead {
            get {
                return ResourceManager.GetString("CodePathAhead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to strada a sx.
        /// </summary>
        public static string CodePathLeft {
            get {
                return ResourceManager.GetString("CodePathLeft", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to strada a dx.
        /// </summary>
        public static string CodePathRight {
            get {
                return ResourceManager.GetString("CodePathRight", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to d.
        /// </summary>
        public static string CodeRight {
            get {
                return ResourceManager.GetString("CodeRight", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to stella.
        /// </summary>
        public static string CodeStar {
            get {
                return ResourceManager.GetString("CodeStar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to finché.
        /// </summary>
        public static string CodeWhile {
            get {
                return ResourceManager.GetString("CodeWhile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No.
        /// </summary>
        public static string ConfirmationNo {
            get {
                return ResourceManager.GetString("ConfirmationNo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sì.
        /// </summary>
        public static string ConfirmationYes {
            get {
                return ResourceManager.GetString("ConfirmationYes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ☑ &lt;b&gt;Giusto!&lt;/b&gt;.
        /// </summary>
        public static string CorrectAnswer {
            get {
                return ResourceManager.GetString("CorrectAnswer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Molto bene! Sei nel posto giusto e stai guardando {0}..
        /// </summary>
        public static string CorrectPosition {
            get {
                return ResourceManager.GetString("CorrectPosition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 🚨 &lt;b&gt;Errore&lt;/b&gt;
        ///Sono spiacente, qualcosa è andato storto. Riavvia il gioco usando il comando /reset, per favore..
        /// </summary>
        public static string CriticalError {
            get {
                return ResourceManager.GetString("CriticalError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Est.
        /// </summary>
        public static string DirectionEast {
            get {
                return ResourceManager.GetString("DirectionEast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nord.
        /// </summary>
        public static string DirectionNorth {
            get {
                return ResourceManager.GetString("DirectionNorth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sud.
        /// </summary>
        public static string DirectionSouth {
            get {
                return ResourceManager.GetString("DirectionSouth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ovest.
        /// </summary>
        public static string DirectionWest {
            get {
                return ResourceManager.GetString("DirectionWest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to verso est.
        /// </summary>
        public static string FacingEast {
            get {
                return ResourceManager.GetString("FacingEast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to verso nord.
        /// </summary>
        public static string FacingNorth {
            get {
                return ResourceManager.GetString("FacingNorth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to verso sud.
        /// </summary>
        public static string FacingSouth {
            get {
                return ResourceManager.GetString("FacingSouth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to verso ovest.
        /// </summary>
        public static string FacingWest {
            get {
                return ResourceManager.GetString("FacingWest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;b&gt;Hai completato il gioco.&lt;/b&gt; Grazie mille per aver partecipato! 👏 Usa il comando /reset se desideri giocare nuovamente..
        /// </summary>
        public static string GameComplete {
            get {
                return ResourceManager.GetString("GameComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vuoi giocare di nuovo? Usa il comando /reset..
        /// </summary>
        public static string GameCompletePrompt {
            get {
                return ResourceManager.GetString("GameCompletePrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 🤖 Ciao! Sono il &lt;b&gt;bot di CodyMaze&lt;/b&gt; e ti guiderò durante il gioco. Una partita è composta da &lt;b&gt;13 sfide&lt;/b&gt;: per ogni sfida, ti invierò delle istruzioni che dovrai seguire esattamente in modo da raggiungere la destinazione finale della scacchiera..
        /// </summary>
        public static string Help1 {
            get {
                return ResourceManager.GetString("Help1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Per iniziare a giocare, ti prego di scansionare uno dei QR Code che si trovano lunga il bordo della scacchiera (sarebbe a dire, un codice qualsiasi sulla prima o ultima riga, o sulla prima o ultima colonna). Potrai usare qualsiasi applicazione di scansione dei QR Code per farlo..
        /// </summary>
        public static string Help2 {
            get {
                return ResourceManager.GetString("Help2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Le istruzioni che ti invierò per spostarti nella scacchiera potranno contenere i seguenti comandi:
        ///&lt;code&gt;f&lt;/code&gt;: muoviti avanti,
        ///&lt;code&gt;l&lt;/code&gt;: ruota a sinistra di 90 gradi,
        ///&lt;code&gt;r&lt;/code&gt;: ruota a destra di 90 gradi,
        ///e altre istruzioni come &lt;code&gt;if&lt;/code&gt;, &lt;code&gt;else&lt;/code&gt;, e &lt;code&gt;while&lt;/code&gt;. I blocchi di codice tra parentesi graffe (&lt;code&gt;{}&lt;/code&gt;) potranno essere ripetute. Ad esempio, &lt;code&gt;2{fr}&lt;/code&gt; vuol dire che dovrai andare avanti e ruotare a destra due volte, in sequenza..
        /// </summary>
        public static string Help3 {
            get {
                return ResourceManager.GetString("Help3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Che lingua vuoi parlare?.
        /// </summary>
        public static string LanguageCommandAsk {
            get {
                return ResourceManager.GetString("LanguageCommandAsk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Va bene!.
        /// </summary>
        public static string LanguageConfirm {
            get {
                return ResourceManager.GetString("LanguageConfirm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ricominciamo! 👍 Scansiona uno dei QR Code lungo il bordo della scacchiera per iniziare a giocare..
        /// </summary>
        public static string ResetCommandOk {
            get {
                return ResourceManager.GetString("ResetCommandOk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 🤖 Ciao, sono il &lt;b&gt;bot di CodyMaze&lt;/b&gt;! Vai su una delle caselle lungo il bordo esterno della scacchiera e scansiona il codice QR che trovi lì..
        /// </summary>
        public static string StartCommand {
            get {
                return ResourceManager.GetString("StartCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hmmm, il codice che hai scansionato non sembra valido. Riprova a scansionare uno dei codici QR della scacchiera..
        /// </summary>
        public static string StartCommandCoordInvalid {
            get {
                return ResourceManager.GetString("StartCommandCoordInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 👏 Congratulazioni, hai completato CodyMaze!.
        /// </summary>
        public static string Victory {
            get {
                return ResourceManager.GetString("Victory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Posizione di inizio non valida: ti prego di andare su una delle caselle lungo il bordo esterno della scacchiera e scansione il codice QR che è lì..
        /// </summary>
        public static string WaitForLocationFirstCoordinateWrong {
            get {
                return ResourceManager.GetString("WaitForLocationFirstCoordinateWrong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 🧭 Girati {0}..
        /// </summary>
        public static string WaitForLocationFirstSendDirection {
            get {
                return ResourceManager.GetString("WaitForLocationFirstSendDirection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ❌ Dovresti guardare &lt;b&gt;{0}&lt;/b&gt;. Conferma cliccando su un pulsante sopra..
        /// </summary>
        public static string WaitForLocationWrongDirection {
            get {
                return ResourceManager.GetString("WaitForLocationWrongDirection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 🤖 Ciao {0}, ti do il benvenuto al gioco &lt;b&gt;{1}&lt;/b&gt;! Iniziamo a giocare..
        /// </summary>
        public static string WelcomeGame {
            get {
                return ResourceManager.GetString("WelcomeGame", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ❌ &lt;b&gt;Sbagliato!&lt;/b&gt; Prova di nuovo..
        /// </summary>
        public static string WrongAnswerTryAgain {
            get {
                return ResourceManager.GetString("WrongAnswerTryAgain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 🚩 &lt;b&gt;Mossa sbagliata!&lt;/b&gt;
        ///Torna in posizione {0} e guarda {1}, dopodiché esegui nuovamente le istruzioni:
        ///
        ///&lt;code&gt;{2}&lt;/code&gt;.
        /// </summary>
        public static string WrongMove {
            get {
                return ResourceManager.GetString("WrongMove", resourceCulture);
            }
        }
    }
}
