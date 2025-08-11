# 🎬 Facade Pattern — Video Processing Example

This repo demonstrates the **Facade Design Pattern** by wrapping a multi-step video pipeline behind **one simple API**.

## 🧠 Problem

Without a facade, the client must coordinate several services in the right order:

- `VideoUploader`
- `VideoConverter`
- `AudioNormalizer`
- `MetadataExtractor`
- `CdnUploader`
- `Notifier`

That creates **tight coupling**, duplicated sequences, and code that’s hard to change or reuse.

## ✅ Solution (Facade)

Expose one entry point that hides the subsystem details:

```csharp
new VideoProcessingFacade().Process(fileName, teacherEmail);
```

Internally, the facade:
1) Saves the uploaded file  
2) Converts it to MP4  
3) Normalizes audio  
4) Extracts metadata  
5) Uploads to CDN  
6) Sends a notification with the final URL

The client stays **clean** while the pipeline can evolve freely.

---

## ▶️ How to Run

```bash
dotnet run
```

Then enter:
- **Video file name** (e.g., `lesson1.avi`)
- **Teacher’s email** (e.g., `teacher@example.com`)

**Program.cs (client):**
```csharp
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("📁 Enter video file name (e.g., lesson1.avi): ");
var fileName = Console.ReadLine();

Console.Write("📧 Enter teacher's email: ");
var email = Console.ReadLine();

new VideoProcessingFacade().Process(fileName, email);
```

> Want to see the complexity without a facade? Check the commented block that calls each service step-by-step.

---

## 🧩 Before vs After

**Before (coupled client):**
```csharp
// var uploader = new VideoUploader();
// var converter = new VideoConverter();
// var normalizer = new AudioNormalizer();
// var metadataExtractor = new MetadataExtractor();
// var cdnUploader = new CdnUploader();
// var notifier = new Notifier();
//
// var path = uploader.Save(fileName);
// var mp4Path = converter.ConvertToMp4(path);
// normalizer.Normalize(mp4Path);
// var metadata = metadataExtractor.Extract(mp4Path);
// var cdnUrl = cdnUploader.Upload(mp4Path);
// notifier.Send(teacherEmail, cdnUrl);
//
// Console.WriteLine("✅ Video is ready to publish!");
```

**After (facade):**
```csharp
new VideoProcessingFacade().Process(fileName, teacherEmail);
```

- Less coupling ✅  
- One clear entry point ✅  
- Easy to change steps internally ✅

---

## 📂 Suggested Structure

```
FacadePattern/
├─ Facade/
│  └─ VideoProcessingFacade.cs
├─ Services/
│  ├─ VideoUploader.cs
│  ├─ VideoConverter.cs
│  ├─ AudioNormalizer.cs
│  ├─ MetadataExtractor.cs
│  ├─ CdnUploader.cs
│  └─ Notifier.cs
└─ Program.cs
```

---

## 🧪 Sample Output

```
📁 Enter video file name (e.g., lesson1.avi): lesson1.avi
📧 Enter teacher's email: teacher@example.com
✅ Video saved at: /videos/lesson1.avi
🎞️ Video converted to MP4: /videos/lesson1.mp4
🔊 Audio normalized.
📏 Video metadata:
   🕒 Duration   : 12:34
   📐 Resolution : 1920x1080
   💾 Size       : 250MB
☁️ Uploaded to CDN: https://cdn.example.com/lesson1.mp4
📨 Notification sent to: teacher@example.com
✅ Video is ready to publish!
```

---

## 🎯 When to Use Facade

- Orchestrating multi-step workflows
- Reducing duplication across clients
- Exposing a simple interface while hiding subsystem complexity

---
