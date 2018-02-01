import subprocess

def subprocess_cmd(command):
    process = subprocess.Popen(command,stdout=subprocess.PIPE, shell=True)
    proc_stdout = process.communicate()[0].strip()
    print (proc_stdout)

filename = '/home/mert/Downloads/tables.txt'

with open(filename) as f:
    content = f.read().splitlines()

for command in content:
    subprocess_cmd(command)
