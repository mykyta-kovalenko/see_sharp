import requests


def download_vimeo_video(url, file_path):
    try:
        response = requests.get(url, stream=True)
        if response.status_code == 200:
            with open(file_path, 'wb') as file:
                for chunk in response.iter_content(chunk_size=1024):
                    file.write(chunk)
            print(f"Download complete for {file_path}!")
        else:
            print(f"Error: Unable to download video from {url} - Response Code", response.status_code)
    except Exception as e:
        print("An error occurred:", e)

# List of videos and their output paths
videos_to_download = [
    {"url": "", "path": ""},
    # Add more videos here
    # ...
]

# Loop through the videos and download each one
for video in videos_to_download:
    download_vimeo_video(video['url'], video['path'])