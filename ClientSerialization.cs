using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class ClientSerialization
{
    /**| Sauvegarde un nouvel objet |**/
    public static void Save(List<Aworknote> listOfWorknotes, string filePath)
    {
        /**| Création et ouverture du fichier |**/
        FileStream file = File.Create(filePath);

        /**| Permet de sérialiser un objet |**/
        BinaryFormatter serealizer = new BinaryFormatter();

        /**| Serealization |**/
        serealizer.Serialize(file, listOfWorknotes);

        /**| Fermeture du fichier |**/
        file.Close();
    }

    /**| Ouvre le fichier |**/
    public static List<Aworknote> Open(string filePath)
    {
        List<Aworknote> listOfWorknotes = new List<Aworknote>();

        if (File.Exists(filePath))
        {
            /**| Lecteur de fichier |**/
            FileStream fs = null;

            try
            {
                /**| Ouverture |**/
                fs = File.OpenRead(filePath);

                /**| Déserialize le fichier |**/
                BinaryFormatter bf = new BinaryFormatter();

                /**| Récupération du contenu |**/
                listOfWorknotes = (List<Aworknote>)bf.Deserialize(fs);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        return listOfWorknotes;
    }

    /**| Supprime et recréer le fichier |**/
    public static void Delete(string worknoteTitle, string filePath)
    {
        List<Aworknote> listOfWorknotes = new List<Aworknote>();

        if (File.Exists(filePath))
        {
            /**| Lecteur de fichier |**/
            FileStream fileStream = null;

            try
            {
                /**| Ouverture |**/
                fileStream = File.OpenRead(filePath);

                /**| Déserialize le fichier |**/
                BinaryFormatter bf = new BinaryFormatter();

                /**| Récupération du contenu |**/
                listOfWorknotes = (List<Aworknote>)bf.Deserialize(fileStream);

                fileStream.Close();

                /**| Index pour la boucle |**/
                int index = 0;
                int indexForRemove = 0;

                /**| On enlève l'objet à l'index qu'on veux supprimer correspond |**/
                foreach (Aworknote aWorknote in listOfWorknotes)
                {
                    if (worknoteTitle == aWorknote.Title)
                    {
                        indexForRemove = index;
                    }
                    index += 1;
                }

                /**| On enlève de la collection |**/
                listOfWorknotes.RemoveAt(indexForRemove);

                /**| On recréer le fichier |**/
                FileStream file = File.Create(filePath);

                /**| On le reserialize |**/
                BinaryFormatter serealizer = new BinaryFormatter();
                serealizer.Serialize(file, listOfWorknotes);

                /**| Fermeture du fichier |**/
                file.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}