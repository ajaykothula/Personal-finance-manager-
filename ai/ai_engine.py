import os
import requests

API_KEY = os.environ.get("")

URL = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent"

def ask_ai(prompt):
    headers = {
        "Content-Type": "application/json",
        "X-goog-api-key": API_KEY
    }

    payload = {
        "contents": [
            {
                "parts": [
                    {"text": prompt}
                ]
            }
        ]
    }

    response = requests.post(URL, headers=headers, json=payload)

    if response.status_code == 200:
        data = response.json()
        return data["candidates"][0]["content"]["parts"][0]["text"]

    return f"Error: {response.text}"
