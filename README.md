
---

# 📌 **Projet AR – Détection de voiture en Réalité Augmentée avec Unity & Vuforia**

## 🚗 Présentation du projet

Ce projet consiste à développer une application en **Réalité Augmentée (AR)** utilisant **Unity** et **Vuforia**.
Lorsqu’une image cible est détectée par la caméra, un **modèle 3D de voiture (Porsche 911 GT3 RS)** apparaît en AR, accompagné d’un **son de moteur** et d’une **voix descriptive**.

Ce projet a été réalisé dans le cadre d’un mini-projet éducatif dédié à l’exploration de l’AR.

---

## 🛠️ Technologies & outils

| Technologie      | Version             |
| ---------------- | ------------------- |
| Unity            | 2021 / 2022+        |
| Vuforia Engine   | 11.x                |
| C#               | Scripts Unity       |
| Plateforme cible | Android / Webcam PC |

---

## 📌 Objectifs pédagogiques

✔ Comprendre les principes de la Réalité Augmentée
✔ Manipuler Vuforia et configurer une ARCamera
✔ Créer et importer une base d’Image Targets
✔ Intégrer un modèle 3D et des éléments multimédia (audio)
✔ Tester l’application sur PC ou smartphone

---
## 📂 Structure du projet

```bash
Assets/
 ├─ Editor/
 ├─ Vuforia/
 │   └─ ImageTargetTextures/
 │       └─ Education/              # Images cibles du projet
 ├─ Resources/
 ├─ Scenes/
 ├─ script/                         # (ancien dossier scripts non utilisé)
 ├─ SportCar/                       # Contenu complet du modèle 3D
 │   ├─ Doc/
 │   ├─ Materials/
 │   ├─ Models/                     # Modèle 3D Porsche 911 GT3 RS
 │   ├─ Prefabs/
 │   ├─ Scenes/
 │   └─ Textures/
 ├─ StreamingAssets/
 │   └─ Vuforia/                    # Base de données (Education.xml + .dat)
 └─ Audio/
     ├─ description voice.mp3
     └─ Porsche GT3 RS Sound.mp3
````

---

## 💻 Scripts utilisés

```bash
Scripts/
 ├─ TargetAudioController.cs        # Lecture/arrêt audio selon le tracking
 ├─ SlowRotation.cs                 # Rotation du modèle 3D
 └─ simpleDefaultTrackableEventHandler.cs
```

---

## 🔑 Fonctionnement de l'application

1️⃣ L'utilisateur pointe la caméra vers l’image cible **car.jpg**
2️⃣ Vuforia détecte l’image
3️⃣ Le modèle 3D de la voiture apparaît en AR
4️⃣ Les sons (**voix descriptive + moteur**) se déclenchent automatiquement
5️⃣ Lorsque la cible disparaît → le modèle disparaît + les sons s’arrêtent

---

## 🖼️ Captures d’écran du projet

### 🔹 Interface Unity – Hiérarchie et scène

<img width="1919" alt="UnityScene" src="https://github.com/user-attachments/assets/4a0be1c7-a2d9-443e-b48d-5e00e2e287ff" />

### 🔹 Script C# dans l’Inspector (TargetAudioController)

<img width="539" alt="AudioControllerScript" src="https://github.com/user-attachments/assets/c2c72bb9-515d-4720-8cc3-d9cf3294c030" />

### 🔹 Réglages Audio pour la détection AR

<img width="1919" alt="InspectorAudio" src="https://github.com/user-attachments/assets/b910c28d-eab6-4f3f-939a-4f8a70c35fe3" />

### 🔹 Prévisualisation AR dans Game View

<img width="1919" alt="ARPreview" src="https://github.com/user-attachments/assets/5097a343-a4fd-433e-b988-8f3bff9fd904" />

### 🔹 Résultat final sur smartphone

<img width="1919" alt="PhoneResult" src="https://github.com/user-attachments/assets/9db4e330-c6f0-419b-9677-2ed4b8c9ca0c" />

---

## 🎬 Vidéo de démonstration du projet AR

📌 **Fonctionnalités visibles dans la vidéo :**

* Détection de l’image cible via la caméra
* Apparition du modèle 3D de la voiture
* Lecture de la voix descriptive
* Lecture du son du moteur
* Disparition du modèle et arrêt des sons lorsque la cible n’est plus détectée

▶ **Vidéo de démonstration :**
[https://github.com/user-attachments/assets/5268ede2-ef76-41c2-a12f-94a47a0652be](https://github.com/user-attachments/assets/5268ede2-ef76-41c2-a12f-94a47a0652be)

---

## 👤 Réalisé par

| Information             | Détail           |
| ----------------------- | ---------------- |
| **Nom**                 | **HASSAOUI Aya** |
| **Établissement**       | **ENS**          |
| **Année universitaire** | **2025 / 2026**  |
