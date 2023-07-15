fileList = ('information.docx', 'Hello.txt', 'myImage.png', \
            'myMovie.mpg', 'World.txt', 'data.pdf', 'myPhoto.jpg')

print((fileList[1]),(fileList[4]))

import sqlite3

conn = sqlite3.connect('fileList.db')

with conn:
    cur = conn.cursor()
    cur.execute("CREATE TABLE IF NOT EXISTS tbl_txtlist\
        (ID INTEGER PRIMARY KEY AUTOINCREMENT, \
        col_txt TEXT)")
    conn.commit()
conn.close()


conn = sqlite3.connect('fileList.db')

with conn:
    cur = conn.cursor()
    for item in fileList:
        if item.endswith(".txt"):
            cur.execute("INSERT INTO tbl_txtlist(col_txt) VALUES (?)",
                        (item,))
            print(item)
    conn.commit()
conn.close()
    
